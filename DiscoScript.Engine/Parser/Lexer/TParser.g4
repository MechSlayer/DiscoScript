parser grammar TParser;

options {
    tokenVocab = TLexer;
}

main: statements | EOF;

statements: (statement  SemiColon?)*; 

statement
    : varDeclaration
    | functionDeclaration
    | returnStatement                            
    | forILoop                                           
    | forEachLoop
    | ifStatement
    | expression                                 
    ;


expression
    : Identifier                                        # Identifier
    | NullLiteral                                       # Literal
    | BooleanLiteral                                    # Literal
    | DecimalLiteral                                    # Literal
    | StringLiteral                                     # Literal
    | NaN                                               # Literal
    | Import expression                                 # ImportExpression
    | expression assignment expression                  # AssignmentExpression
    | expression ('*' | '/' | '%') expression           # BinaryOperation
    | expression ('+' | '-') expression                 # BinaryOperation
    | expression '??' expression                        # CoalesceExpression
    | expression '???' expression                       # UndefinedCoalesce
    | expression ('<' | '>' | '<=' | '>=') expression   # BinaryOperation
    | expression ('==' | '!=') expression               # BinaryOperation
    | expression ('&&' | '||') expression               # BinaryOperation
    | '(' expression ')'                                # ParenthesedExpression
    | '[' commaExpressions? ']'                         # ArrayDeclaration
    | expression '(' commaExpressions? ')'              # CallFunction
    | '<-' expression '(' commaExpressions? ')'         # AsyncCallFunction
    | '->' expression                                   # WaitAsync
    | '(' identifiers? ')' '=>' codeBlock               # ArrowFunction
    | expression '.' Identifier                         # ObjectAccess
    | '{' (objectMember ','?)* '}'                      # ObjectDeclaration
    | expression '++'                                   # Increment
    | expression '--'                                   # Decrement
    | expression '[' expression ']'                     # IndexAccess
    | expression '[' expression ']' assignment expression # IndexAssignment
    ;
    
forILoop: For '(' forLoopStart ';' expression ';' expression ')' codeBlock;
forEachLoop: For '(' Var Identifier In expression ')' codeBlock;

forLoopStart: (Var Identifier '=' expression) # DeclarativeLoopInit | (Identifier '=' expression) #AssignmentLoopInit | Identifier # IdentifierLoopInit;

ifStatement: 'si' '(' expression ')' codeBlock elseStatement?;
elseStatement: 'si_no' codeBlock;

varDeclaration: Var Identifier (Assign expression)?;
functionDeclaration: Function Identifier '(' identifiers? ')' codeBlock;
returnStatement: 'devolver' expression?;

identifiers: Identifier (',' Identifier)*;

commaExpressions: expression (',' expression)*;

codeBlock: (statement | expression) | '{' statements '}';

objectMember: Identifier ':' expression;
functionCallable
    : Identifier
    ;
    
assignment: '=' | '+=' | '-=' | '*=' | '/=';
functionCall: functionCallable '(' commaExpressions ')';

