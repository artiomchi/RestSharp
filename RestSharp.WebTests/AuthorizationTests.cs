﻿#region License
//   Copyright 2010 John Sheehan
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License. 
#endregion

using Xunit;

namespace RestSharp.WebTests
{
	public class AuthorizationTests
	{
		[Fact]
		public void Can_Authenticate_With_Basic_Http_Auth() {
			var request = new RestRequest { BaseUrl = "http://localhost:56976", Action = "Authentication/Basic" };
			
			var client = new RestClient();
			client.Authenticator = new HttpBasicAuthenticator("testuser", "testpassword");

			var response = client.Execute(request);

			Assert.Equal("testuser|testpassword", response.Content);
		}
	}
}