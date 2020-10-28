using System;
using System.Collections.Generic;
using System.Text;

namespace  Stackoverflow.Domain.Schema
{

	[Serializable]
	public class InvalidVotesException : Exception
	{
		public InvalidVotesException()
		{ }
		public InvalidVotesException(int votes) : base($"The value \"{votes}\" does not correspond with the real one")
		{ }
	}

}