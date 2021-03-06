﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license.
//
// Microsoft Bot Framework: http://botframework.com
// Microsoft Teams: https://dev.office.com/microsoft-teams
//
// Bot Builder SDK GitHub:
// https://github.com/Microsoft/BotBuilder
//
// Bot Builder SDK Extensions for Teams
// https://github.com/OfficeDev/BotBuilder-MicrosoftTeams
//
// Copyright (c) Microsoft Corporation
// All rights reserved.
//
// MIT License:
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED ""AS IS"", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TeamsAdmin.Models
{
    public class GroupInfo
    {
        public string id { get; set; }
        public string description { get; set; }
        public string displayName { get; set; }
        public string[] groupTypes { get; set; }
        public bool mailEnabled { get; set; }
        public string mailNickname { get; set; }
        public bool securityEnabled { get; set; }

        [JsonProperty(PropertyName = "owners@odata.bind")]
        public string[] Owners { get; set; }
    }

    public class AllTeams
    {
        [JsonProperty("@odata.nextLink")]
        public string odatanextLink { get; set; }

        public List<GroupInfo> value { get; set; }
    }

    public class InvitationRequest
    {
        public string invitedUserEmailAddress { get; set; }
        public string inviteRedirectUrl { get; set; }
        public bool sendInvitationMessage { get; set; }
        public Invitedusermessageinfo invitedUserMessageInfo { get; set; }
    }

    public class Invitedusermessageinfo
    {
        public string customizedMessageBody { get; set; }
    }



    public class InvitationResponse
    {
        public Inviteduser invitedUser { get; set; }
    }


    public class Inviteduser
    {
        public string id { get; set; }
    }


}