using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TSQL.Tokens;

namespace TSQL
{
	public interface ITSQLTokenizer : IEnumerator, IEnumerable, IEnumerator<TSQLToken>, IEnumerable<TSQLToken>
	{
		void Putback();
		bool UseQuotedIdentifiers { get; set; }
		bool IncludeWhitespace {get; set; }
	}
}
