// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
//
// Generated with Bot Builder V4 SDK Template for Visual Studio EchoBot v4.6.2

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;

namespace ExodusLoansBot.Bots
{
    public class EchoBot : ActivityHandler
    {
       

        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    await turnContext.SendActivityAsync(CreateActivityWithTextAndSpeak($"Hello and welcome to Exodus Freedom Loans!" +
                        $" We are a Tuscaloosa non-profit that specializes in granting loans."), cancellationToken);

                    await turnContext.SendActivityAsync(CreateActivityWithTextAndSpeak($"If you are a partner looking to sign in, the login portal is located in the top right corner of the site." +
                       $" Once you login you will be able to review loan applications."), cancellationToken);
                   
                    await turnContext.SendActivityAsync(CreateActivityWithTextAndSpeak($"If you would like to donate to Exodus Freedom Loans, at the bottom of our site you will find a donation link." +
                       $" Any donation is appreciated to help local Tuscaloosa families pay off high interest loans."), cancellationToken);

                    await turnContext.SendActivityAsync(CreateActivityWithTextAndSpeak($"Thank you for choosing Exodus Freedom Loans." +
                       $" We look forward to helping you with any of your financial needs!"), cancellationToken);
                }
            }
        }

        private IActivity CreateActivityWithTextAndSpeak(string message)
        {
            var activity = MessageFactory.Text(message);
            string speak = @"<speak version='1.0' xmlns='https://www.w3.org/2001/10/synthesis' xml:lang='en-US'>
              <voice name='Microsoft Server Speech Text to Speech Voice (en-US, JessaRUS)'>" +
              $"{message}" + "</voice></speak>";
            activity.Speak = speak;
            return activity;
        }
    }
}
