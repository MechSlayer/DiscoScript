using System.Linq;
using Antlr4.Runtime;

using DiscoScript.Engine.Parser.Lexer;
using DiscoScript.Engine.Parser.Nodes;
using DiscoScript.Engine.Parser.Nodes.Expressions;
using DiscoScript.Engine.Parser.Nodes.Statements;

namespace DiscoScript.Engine.Parser
{
    public class Parser : TParserBaseVisitor<Node>
    {
        
        public NodesCollection<Node> Parse(string code)
        {
            var input = new AntlrInputStream(code);
            var lexer = new TLexer(input);
            var tokens = new CommonTokenStream(lexer);
            tokens.Fill();


            var parser = new TParser(tokens);
            parser.RemoveErrorListeners();
            parser.AddErrorListener(ParseErrorListener.Instance);
            
            var res = VisitMain(parser.main());
            return res.As<NodesCollection<Node>>();
        }
        public override Node VisitMain(TParser.MainContext context)
        {
            return VisitStatements(context.statements());
        }

        public override Node VisitStatements(TParser.StatementsContext context)
        {
            var nodes = new NodesCollection<Node>(context.Start);
            foreach (var statement in context.statement())
                nodes.Add(Visit(statement));
            return nodes;
        }

        public override Node VisitLiteral(TParser.LiteralContext context)
        {
            return new Literal(context, context.Start);
        }

        public override Node VisitIdentifier(TParser.IdentifierContext context)
        {
            return new Identifier(context.GetText(), context.Start);
        }

        public override Node VisitIdentifiers(TParser.IdentifiersContext context)
        {
            var nodes = new NodesCollection<Identifier>(context.Start);
            foreach (var exp in context.Identifier())
                nodes.Add(new Identifier(exp.GetText(), exp.Symbol));
            return nodes;
        }

        public override Node VisitVarDeclaration(TParser.VarDeclarationContext context)
        {
            var id = new Identifier(context.Identifier().GetText(), context.Identifier().Symbol);
            var init = context.expression().IsEmpty ? null : Visit(context.expression());
            return new VarDeclaration(id, init, context.Start);
        }

        public override Node VisitBinaryOperation(TParser.BinaryOperationContext context)
        {
            var left = context.expression(0);
            var right = context.expression(1);
            var op = context.children[1].GetText();
            return new BinaryOperation(Visit(left), op, Visit(right), context.Start);
        }

        public override Node VisitParenthesedExpression(TParser.ParenthesedExpressionContext context)
        {
            return Visit(context.expression());
        }

        public override Node VisitFunctionDeclaration(TParser.FunctionDeclarationContext context)
        {
            var name = new Identifier(context.Identifier().GetText(), context.Identifier().Symbol);
            var args = context.identifiers() == null ? new NodesCollection<Identifier>(context.Identifier().Symbol) : VisitIdentifiers(context.identifiers()).As<NodesCollection<Identifier>>();
            var body = VisitCodeBlock(context.codeBlock()).As<NodesCollection<Node>>();
            return new FunctionDeclaration(name, args, body, context.Start);
        }

        public override Node VisitCodeBlock(TParser.CodeBlockContext context)
        {
            var body = new NodesCollection<Node>(context.Start);
            if (context.expression() != null && !context.expression().IsEmpty)
                body.Add(Visit(context.expression()));
            else if (context.statements() != null && !context.statements().IsEmpty)
                body = VisitStatements(context.statements()).As<NodesCollection<Node>>();
            else if (context.statement() != null && !context.statement().IsEmpty)
                body.Add(Visit(context.statement()));

            return body;
        }

        
        public override Node VisitObjectAccess(TParser.ObjectAccessContext context)
        {
            var path = new NodesCollection<Node>(context.Start);
            VisitObjectAccess(context, path);
            var obj = new ObjectAccess(path[0], null, path[0].Position);
            foreach (var node in path.Skip(1))
                obj = new ObjectAccess(node, obj, node.Position);
            return obj;
        }

        private void VisitObjectAccess(TParser.ObjectAccessContext context, NodesCollection<Node> path)
        {
            while (true)
            {
                var id = new Identifier(context.Identifier().GetText(), context.Identifier().Symbol);
                path.Add(id);
                var leftExp = context.expression();
                if (leftExp is TParser.ObjectAccessContext objCtx)
                {
                    context = objCtx;
                    continue;
                }
                else
                    path.Add(Visit(leftExp));

                break;
            }
        }

        public override Node VisitCallFunction(TParser.CallFunctionContext context)
        {
            var target = Visit(context.expression());
            var @params = context.commaExpressions() == null
                ? new NodesCollection<Node>(context.Start)
                : Visit(context.commaExpressions()).As<NodesCollection<Node>>(); 
            return new FunctionCall(target, @params, context.Start);
        }

        public override Node VisitAsyncCallFunction(TParser.AsyncCallFunctionContext context)
        {
            var target = Visit(context.expression());
            var @params = context.commaExpressions() == null
                ? new NodesCollection<Node>(context.Start)
                : Visit(context.commaExpressions()).As<NodesCollection<Node>>(); 
            return new FunctionCall(target, @params, context.Start, true);
        }

        public override Node VisitCommaExpressions(TParser.CommaExpressionsContext context)
        {
            var nodes = new NodesCollection<Node>(context.Start);
            foreach (var exp in context.expression())
                nodes.Add(Visit(exp));
            return nodes;
        }

        public override Node VisitWaitAsync(TParser.WaitAsyncContext context)
        {
            return new WaitAsyncNode(Visit(context.expression()), context.Start);
        }

        public override Node VisitAssignmentExpression(TParser.AssignmentExpressionContext context)
        {
            var target = Visit(context.expression(0));
            var init = Visit(context.expression(1));
            var op = context.assignment().GetText();
            return new AssignmentNode(target, op, init, context.Start);
        }

        public override Node VisitObjectMember(TParser.ObjectMemberContext context)
        {
            var name = new Identifier(context.Identifier().GetText(), context.Identifier().Symbol);
            var init = Visit(context.expression());
            return new ObjectMember(name, init, context.Start);
        }

        public override Node VisitObjectDeclaration(TParser.ObjectDeclarationContext context)
        {
            var col = new NodesCollection<ObjectMember>(context.Start);
            if (context.objectMember() == null) return col;
            foreach (var member in context.objectMember())
                col.Add(VisitObjectMember(member).As<ObjectMember>());
            return new ObjectDeclaration(col, context.Start);
        }

        public override Node VisitArrayDeclaration(TParser.ArrayDeclarationContext context)
        {
            var col = new NodesCollection<Node>(context.Start);
            if (context.commaExpressions() == null) return new ArrayDeclaration(col, context.Start);
            foreach (var exp in context.commaExpressions().expression())
                col.Add(Visit(exp));
            return new ArrayDeclaration(col, context.Start);
        }

        public override Node VisitForEachLoop(TParser.ForEachLoopContext context)
        {
            var init = new Identifier(context.Identifier().GetText(), context.Identifier().Symbol);
            var target = Visit(context.expression());
            var body = Visit(context.codeBlock());
            return new ForEachLoop(init, target, body, context.Start);
        }

        public override Node VisitIncrement(TParser.IncrementContext context)
        {
            return new AssignmentNode(Visit(context.expression()), "+=", new Literal(1, context.expression().Start),
                context.Start);
        }

        public override Node VisitDecrement(TParser.DecrementContext context)
        {
            return new AssignmentNode(Visit(context.expression()), "-=", new Literal(1, context.expression().Start),
                context.Start);
        }

        public override Node VisitReturnStatement(TParser.ReturnStatementContext context)
        {
            return new ReturnNode(context.expression().Accept(this), context.Start);
        }

        public override Node VisitForILoop(TParser.ForILoopContext context)
        {
            var init = Visit(context.forLoopStart());
            var condition = Visit(context.expression(0));
            var update = Visit(context.expression(1));
            var body = Visit(context.codeBlock());
            return new ForILoop(init, condition, update, body, context.Start);
        }

        public override Node VisitAssignmentLoopInit(TParser.AssignmentLoopInitContext context)
        {
            return new AssignmentNode(new Identifier(context.Identifier().GetText(), context.Identifier().Symbol),
                context.Assign().GetText(), Visit(context.expression()), context.Start);
        }

        public override Node VisitDeclarativeLoopInit(TParser.DeclarativeLoopInitContext context)
        {
            return new VarDeclaration(new Identifier(context.Identifier().GetText(), context.Identifier().Symbol), Visit(context.expression()), context.Start);
        }

        public override Node VisitIdentifierLoopInit(TParser.IdentifierLoopInitContext context)
        {
            return new Identifier(context.Identifier().GetText(), context.Identifier().Symbol);
        }

        public override Node VisitIfStatement(TParser.IfStatementContext context)
        {
            var condition = Visit(context.expression());
            var body = Visit(context.codeBlock());
            var elseN = context.elseStatement() == null
                ? new NodesCollection<Node>(context.Stop)
                : Visit(context.elseStatement());
            
            return new IfNode(condition, body, elseN, context.Start);
        }

        public override Node VisitElseStatement(TParser.ElseStatementContext context)
        {
            return Visit(context.codeBlock());
        }

        public override Node VisitIndexAccess(TParser.IndexAccessContext context)
        {
            var target = Visit(context.expression(0));
            var index = Visit(context.expression(1));
            return new IndexAccess(target, index, context.Start);
        }

        public override Node VisitIndexAssignment(TParser.IndexAssignmentContext context)
        {
            var target = Visit(context.expression(0));
            var index = Visit(context.expression(1));
            var op = context.assignment().GetText();
            var init = Visit(context.expression(2));
            return new IndexAssignment(target, index, op, init, context.Start);
        }
    }
}