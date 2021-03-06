/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Domain_intl.Transform;
using Aliyun.Acs.Domain_intl.Transform.V20171218;

namespace Aliyun.Acs.Domain_intl.Model.V20171218
{
    public class RegistrantProfileRealNameVerificationRequest : RpcAcsRequest<RegistrantProfileRealNameVerificationResponse>
    {
        public RegistrantProfileRealNameVerificationRequest()
            : base("Domain-intl", "2017-12-18", "RegistrantProfileRealNameVerification", "domain", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string identityCredentialType;

		private string userClientIp;

		private long? registrantProfileID;

		private string identityCredential;

		private string lang;

		private string identityCredentialNo;

		public string IdentityCredentialType
		{
			get
			{
				return identityCredentialType;
			}
			set	
			{
				identityCredentialType = value;
				DictionaryUtil.Add(QueryParameters, "IdentityCredentialType", value);
			}
		}

		public string UserClientIp
		{
			get
			{
				return userClientIp;
			}
			set	
			{
				userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		public long? RegistrantProfileID
		{
			get
			{
				return registrantProfileID;
			}
			set	
			{
				registrantProfileID = value;
				DictionaryUtil.Add(QueryParameters, "RegistrantProfileID", value.ToString());
			}
		}

		public string IdentityCredential
		{
			get
			{
				return identityCredential;
			}
			set	
			{
				identityCredential = value;
				DictionaryUtil.Add(BodyParameters, "IdentityCredential", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string IdentityCredentialNo
		{
			get
			{
				return identityCredentialNo;
			}
			set	
			{
				identityCredentialNo = value;
				DictionaryUtil.Add(QueryParameters, "IdentityCredentialNo", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RegistrantProfileRealNameVerificationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RegistrantProfileRealNameVerificationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
