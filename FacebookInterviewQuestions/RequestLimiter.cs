using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAlgos.FacebookInterviewQuestions
{
    public class RequestLimiter
    {
        public Dictionary<string, int> rateLimiter;
        public RequestLimiter()
        {
            rateLimiter = new Dictionary<string, int>();
        }

        public bool RequestApprover(int timestamp, string requestId)
        {
            if (!this.rateLimiter.ContainsKey(requestId))
            {
                this.rateLimiter[requestId] = timestamp;
                Console.WriteLine("Request Accepted");
                return true;
            }

            int oldtimestamp = this.rateLimiter[requestId];

            if(timestamp - oldtimestamp > 5)
            {
                this.rateLimiter[requestId] = timestamp;
                Console.WriteLine("Request Accepted !");
                return true;
            }
            else
            {
                Console.WriteLine("Request Rejected !");
            }
            return false;
        }
    }
}
