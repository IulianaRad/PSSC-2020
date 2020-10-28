using LanguageExt.Common;
using System;
using System.Collections.Generic;
using System.Text;
using static Stackoverflow.Domain.Schema.Votes;


namespace Stackoverflow.Domain.Schema.CreateQuestionWorkflow
{
    public class VerifyVotesService
    {
        public Result<VerifiedVotes> VerifyVotes(UnverifiedVotes votes)
        {
            

            return new VerifiedVotes(votes);
        }
    }
}
