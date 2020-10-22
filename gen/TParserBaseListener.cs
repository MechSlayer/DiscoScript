//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:/Users/Mech/RiderProjects/DiscoScript/DiscoScript.Parser/Lexer\TParser.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419


using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ITParserListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class TParserBaseListener : ITParserListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="TParser.main"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMain([NotNull] TParser.MainContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TParser.main"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMain([NotNull] TParser.MainContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TParser.statements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatements([NotNull] TParser.StatementsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TParser.statements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatements([NotNull] TParser.StatementsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>VarDeclaration</c>
	/// labeled alternative in <see cref="TParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVarDeclaration([NotNull] TParser.VarDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>VarDeclaration</c>
	/// labeled alternative in <see cref="TParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVarDeclaration([NotNull] TParser.VarDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>FunctionDeclaration</c>
	/// labeled alternative in <see cref="TParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionDeclaration([NotNull] TParser.FunctionDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FunctionDeclaration</c>
	/// labeled alternative in <see cref="TParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionDeclaration([NotNull] TParser.FunctionDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ReturnStatement</c>
	/// labeled alternative in <see cref="TParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReturnStatement([NotNull] TParser.ReturnStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ReturnStatement</c>
	/// labeled alternative in <see cref="TParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReturnStatement([NotNull] TParser.ReturnStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ExpressionStatement</c>
	/// labeled alternative in <see cref="TParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpressionStatement([NotNull] TParser.ExpressionStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ExpressionStatement</c>
	/// labeled alternative in <see cref="TParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpressionStatement([NotNull] TParser.ExpressionStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ArrayDeclaration</c>
	/// labeled alternative in <see cref="TParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayDeclaration([NotNull] TParser.ArrayDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ArrayDeclaration</c>
	/// labeled alternative in <see cref="TParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayDeclaration([NotNull] TParser.ArrayDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>BinaryOperation</c>
	/// labeled alternative in <see cref="TParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBinaryOperation([NotNull] TParser.BinaryOperationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>BinaryOperation</c>
	/// labeled alternative in <see cref="TParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBinaryOperation([NotNull] TParser.BinaryOperationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ArrowFunction</c>
	/// labeled alternative in <see cref="TParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrowFunction([NotNull] TParser.ArrowFunctionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ArrowFunction</c>
	/// labeled alternative in <see cref="TParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrowFunction([NotNull] TParser.ArrowFunctionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>UndefinedCoalesce</c>
	/// labeled alternative in <see cref="TParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUndefinedCoalesce([NotNull] TParser.UndefinedCoalesceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>UndefinedCoalesce</c>
	/// labeled alternative in <see cref="TParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUndefinedCoalesce([NotNull] TParser.UndefinedCoalesceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>AsyncCallFunction</c>
	/// labeled alternative in <see cref="TParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAsyncCallFunction([NotNull] TParser.AsyncCallFunctionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AsyncCallFunction</c>
	/// labeled alternative in <see cref="TParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAsyncCallFunction([NotNull] TParser.AsyncCallFunctionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Identifier</c>
	/// labeled alternative in <see cref="TParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifier([NotNull] TParser.IdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Identifier</c>
	/// labeled alternative in <see cref="TParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifier([NotNull] TParser.IdentifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>Literal</c>
	/// labeled alternative in <see cref="TParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteral([NotNull] TParser.LiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>Literal</c>
	/// labeled alternative in <see cref="TParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteral([NotNull] TParser.LiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ParenthesedExpression</c>
	/// labeled alternative in <see cref="TParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParenthesedExpression([NotNull] TParser.ParenthesedExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ParenthesedExpression</c>
	/// labeled alternative in <see cref="TParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParenthesedExpression([NotNull] TParser.ParenthesedExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>WaitAsync</c>
	/// labeled alternative in <see cref="TParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWaitAsync([NotNull] TParser.WaitAsyncContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>WaitAsync</c>
	/// labeled alternative in <see cref="TParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWaitAsync([NotNull] TParser.WaitAsyncContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ObjectAccess</c>
	/// labeled alternative in <see cref="TParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterObjectAccess([NotNull] TParser.ObjectAccessContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ObjectAccess</c>
	/// labeled alternative in <see cref="TParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitObjectAccess([NotNull] TParser.ObjectAccessContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ImportExpression</c>
	/// labeled alternative in <see cref="TParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterImportExpression([NotNull] TParser.ImportExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ImportExpression</c>
	/// labeled alternative in <see cref="TParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitImportExpression([NotNull] TParser.ImportExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>CallFunction</c>
	/// labeled alternative in <see cref="TParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCallFunction([NotNull] TParser.CallFunctionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>CallFunction</c>
	/// labeled alternative in <see cref="TParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCallFunction([NotNull] TParser.CallFunctionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>CoalesceExpression</c>
	/// labeled alternative in <see cref="TParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCoalesceExpression([NotNull] TParser.CoalesceExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>CoalesceExpression</c>
	/// labeled alternative in <see cref="TParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCoalesceExpression([NotNull] TParser.CoalesceExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TParser.identifiers"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifiers([NotNull] TParser.IdentifiersContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TParser.identifiers"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifiers([NotNull] TParser.IdentifiersContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TParser.commaExpressions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCommaExpressions([NotNull] TParser.CommaExpressionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TParser.commaExpressions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCommaExpressions([NotNull] TParser.CommaExpressionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TParser.codeBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCodeBlock([NotNull] TParser.CodeBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TParser.codeBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCodeBlock([NotNull] TParser.CodeBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TParser.functionCallable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionCallable([NotNull] TParser.FunctionCallableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TParser.functionCallable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionCallable([NotNull] TParser.FunctionCallableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TParser.functionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionCall([NotNull] TParser.FunctionCallContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TParser.functionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionCall([NotNull] TParser.FunctionCallContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}