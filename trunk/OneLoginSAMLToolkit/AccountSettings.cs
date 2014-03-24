﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OneLoginSAMLToolkit
{
    public class AccountSettings
    {
        public string certificate = "-----BEGIN CERTIFICATE-----" +
            "MIIBrTCCAaGgAwIBAgIBATADBgEAMGcxCzAJBgNVBAYTAlVTMRMwEQYDVQQIDApD" +
            "YWxpZm9ybmlhMRUwEwYDVQQHDAxTYW50YSBNb25pY2ExETAPBgNVBAoMCE9uZUxv" +
            "Z2luMRkwFwYDVQQDDBBhcHAub25lbG9naW4uY29tMB4XDTExMTAxNzIwMjQwMFoX" +
            "DTE2MTAxNjIwMjQwMFowZzELMAkGA1UEBhMCVVMxEzARBgNVBAgMCkNhbGlmb3Ju" +
            "aWExFTATBgNVBAcMDFNhbnRhIE1vbmljYTERMA8GA1UECgwIT25lTG9naW4xGTAX" +
            "BgNVBAMMEGFwcC5vbmVsb2dpbi5jb20wgZ8wDQYJKoZIhvcNAQEBBQADgY0AMIGJ" +
            "AoGBANvMwlWvqKZ2FLBKNEzw4LMpvp3fcfe8laST4iNNYbmPGCB7yUixOF4rFQwd" +
            "oKDZUp4g12FUeIBCqB/0rKg+qu11mrMt+jGJiybedXYrEBu+WCt3kq7qDhSdF0EL" +
            "GflOB4usLgNKxWCRcJgaY1u0i0wp5FuDoZOdQaIrhTUgDLhpAgMBAAEwAwYBAAMB" +
            "AA==" +
            "-----END CERTIFICATE-----";
        public string idp_sso_target_url = "https://app.onelogin.com/saml/signon/71332";
    }
}