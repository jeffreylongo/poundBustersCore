using System;
namespace poundBustersCoreV1.Models
{
    public class Token
    {
        public string token_type { get; set; }
        public string expires_in { get; set; }
        public string access_token { get; set; }


        //"{\"token_type\":\"Bearer\",\"expires_in\":3600,\"access_token\":\"eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJhdWQiOiJnQVI0SUs2Z04xZVV4dXpCTzRLdzdDdzRWQXBGQUM1WExyS0t5ak00MXlyTlVvYW1DUCIsImp0aSI6IjY0Y2Q2MzIwY2VmMGZkMGYwZmJhYzIzNDQ3OWQ5OTIzZjcxMjQ2MTExNDEzMzEwY2E5OTk5MjZjZWZkMTU1ODUyZDNlZWFiY2IwNTQ3NzliIiwiaWF0IjoxNjAyNDU1NzA1LCJuYmYiOjE2MDI0NTU3MDUsImV4cCI6MTYwMjQ1OTMwNSwic3ViIjoiIiwic2NvcGVzIjpbXX0.mIrXxRHCoXsbP9FsB4m1x07Gt5-SCVmMtI_in3pCMpJ0uFDCKI-h_CZaj4unOlE--2Bv9LgX2fG1Ht2M2XqZbggi-x16pSpSogTHHKwdiCfFIP56sJm-deE5rceZ9l0KLLji6MwYvG577cEXYtNxl9sxc4NgwoMDNMrJdllWEdG6Z3IzFuh1hu9lclPiAAUn5IMkSkbvENb87ZyVj3aerEZMhh9B65Xrfo-NYs-OuFsrnDSaKF65xmlTMD02lzx4U2twHjZoVqJ1vM0NHnfBazw8-hABciZvOKp-sokgyMo1NEbnki4LnUjnfQgaFvOLgENSsAlpDkGFwGYNEjx4OQ\"}"
    }
}
