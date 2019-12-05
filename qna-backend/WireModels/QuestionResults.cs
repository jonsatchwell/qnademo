using System;
using System.Collections.Generic;

using System.Globalization;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Qna.Backend.WireModels
{
    public class QuestionResults
    {
        public QuestionResults(){
            this.Votes = new List<VoteCount>();
        }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("questionId")]
        public string QuestionId { get; set; }

        [JsonProperty("answerOptions")]
        public List<VoteCount> Votes { get; set; }
    }
    
    public class VoteCount
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; } 

        [JsonProperty("voteCount")]
        public int Votes { get; set; } = 0;    
    }
}
