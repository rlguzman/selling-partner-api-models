﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.SellingPartnerAPIAA
{
  public class AWSAuthenticationCredentialsProvider
  {
    /**
     * AWS IAM Role ARN
     */
    private string _roleArn;

    /**
     * AWS IAM Role Session Name
     */
    private string _roleSessionName;

    public string roleArn { get => _roleArn; set => _roleArn = value; }
    public string roleSessionName { get => _roleSessionName; set => _roleSessionName = value; }
  }
}
