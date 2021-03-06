﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TSQL.Clauses.Parsers;
using TSQL.Statements;
using TSQL.Tokens;

namespace TSQL.Expressions.Parsers
{
	internal class TSQLCaseExpressionParser
	{
		public TSQLCaseExpression Parse(ITSQLTokenizer tokenizer)
		{
			TSQLCaseExpression caseExpression = new TSQLCaseExpression();

			if (!tokenizer.Current.IsKeyword(TSQLKeywords.CASE))
			{
				throw new InvalidOperationException("CASE expected.");
			}

			caseExpression.Tokens.Add(tokenizer.Current);

			TSQLSubqueryHelper.ReadUntilStop(
				tokenizer,
				caseExpression,
				new List<TSQLFutureKeywords>() { },
				new List<TSQLKeywords>() {
					TSQLKeywords.END
				},
				lookForStatementStarts: false);

			return caseExpression;
		}
	}
}
