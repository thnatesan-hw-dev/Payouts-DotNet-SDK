// This class was generated on Fri, 27 Dec 2019 13:56:46 IST by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// PayoutsItemCancelRequest.cs
// @version 0.1.0-dev+904328-dirty
// @type request
// @data H4sIAAAAAAAC/+xb+2/cNvL//ftXDNQvkAbQ7rpNn/7NsF3Ed23ii50eCp/h5UqjFc8UqXIoO0LR//3Ah7R6rZO4zvYe+5O9M3zMZ2Y4Gg7J36JXrMDoMCpZrSpDM26wmCdMJiiiODpBSjQvDVcyOoyOHZmASahkIhgvMAXfEWy/GFY1nJ3M4SwDqUBJBNeKwOTY6WLbwj03OZfw4gBSVlPsmhydnwGrjCqY4QkTogaNptLSD5BVMiUwyv0glCnqObwlBJNzAtveMr3sUzOuMFMaHaedBF4czFJm57Gjz+EXVdkRmlE64MhJDAz+UR0cvEgSlaL7D41mklhidXRDhpmKfIvFpgmobNTt7avjH4/Ofjo9GbWeR3H0twp1fc40K9Cgpujw6jqOXiJLUQ+pPyhdDGnnzOQ92m/RZV1aO5PRXK6jOPqZac5WAnv2v7FIb3gaxdFfsQ6skR9c5ghnJxaU1WVHRxv9WwxHWrPaT3sQR2+Qpa+lqKPDjAlCS/i14hrT6NDoCuPoXKsSteFI0aGshPj92rdBMn4QS7QkKpUk9LQW17mX4sxK0TQZo3w/ri4ab01gMgVlctSQomFc0ByORubs62/sATmKkqBWFfAUpeFZDSlK7hdQgdKQWzas+QmcQoPY9bJOWZH33o+d26jNpMFibgq8Qwk8A25AsOSW3uPcE0N/lJkDoWvn9/ulnfuOm3rolH362I6V5L9WCOesPmditkaJmhlMIVFFoaR1X5MzA4LLW+oElJmztsYE+R3qGfEUoaMDcgEnhUxpS05uuVz/UR04X4+HjnxcaY0yqSFR8g41WWQj5SSh0U2v0UZJ0/yxspLxZKCRVKWTHZgY3yU5k2u8sRbqyT/kjCVvWoBt4U3KCVhZCt6YyX4c/Ap5Yks1JhojyrQqblihKml6ePr0B+xgndC3cxgYZFwymXAmut4YA1VJDswu3BUTNvCC0u3yTqsdGC/ZKGHsd5Mgr0yuEWdJzjRLDGo4u3g9++rLL77tumGK158vUpXQgkuDa83sAIuUa0zMQiOZRdN4ZhvT4vlTfHHi98K9Y6Lq+2hDGQN1nBjuc57kUPB1bmCFhz6GVsIHUP9LcP/rSIKDi9qZPUDkSCD4LcLyL+e/LL2TM40glQFTlyFTyrR3CibmIUw3ow7mgBQTXjDR9pie6/LVSWcuqlYpv+OpzaWkS8FURUymJqfp6RYNwh/cGkTQQfkgq2KF2mYPjSClYAlS8PSeE8RAiHB13KURzKzLgHWZ689zY0o6XCzu7+/nnNRc6fWCk3IONev7yDw3hXgSP7n+oChg1FQM6FL3EWAfAfYR4D8zAlyPczbUWumJ/MaSqZ/YNKSJjMay2p3GJ1+9Ka6q9TC57hDHAvqU2rmplky4DX+bFCdKaxRurUJZ6VIR0hOnXduQcJkpXbipb2xa30M0wRwje/vmzIHwyneO3vba5JLOQLuJNQUSsXU/2mxoYwCB5xdt6tgr9NubHUot7Z+uyIGwdZOWVwWTM40staOAbR7U/UnkDqv11C20E7/QthZE3Pw3adtqg2pLgz7KIwnMCm6DHUtT7uPzg4v8m6df5BlH0V/hDWVsE6f9UNpxrbw3Jayya/xxJvkDi5po8LVtKGPJNTJqF+qnEfNHLm+hO/NIYFdQ6AncULY7hvZVrpmLnJjC1cujy9PXRxe+OtGkQazkC40Z2u8Z2l8zHepctPgsZwYVo5nr8fzTe1SuMeuhDISJjFYVpUC7OWd6jQbevvlxDpcKCnaLIS3wqG0SE9vmKy49p0CTq9TXXV3ovbIR+hKL0vaY+dhsMN3kAEYpQXOOJnNpgP3cL3SWfPP1twfPnTbnYLORUuOs1CpBIi7XMXCZiCr1ky7/fxnD8vNl7FLw5fMltHkqzcEiWlqsS+A+sN5iDY29LFYlbebdKS6xVgUeY1NHpmpF1vDSOPKOFpTX6eCLEkhj4728vDxvzNCmb2aL8XaEQLuTiY34euKkwu0yrPqhzUZMXeJ7HeXr77/77jNClxTPvnrepO6E+g7JbbNc6dDnqW58Z+hKsmLF15WqSNSDDy9hwaThCTVB1bvhhc1qXTh5EySkQSrLJHOyMSK+lq5EvLB9Zw2k4c/5u49Pb7eZ4XqQ4e4D3z7w7QPfPvD9DwS++EPPSlfMJPlw6zzmbdtBdw6lgmY7p6mu/yfZ9rgTUr/refAUeApVoI8RhZ1M8I9wlJZodOgCJKMsi8u1sKsn4SVHaf4gxKsPKMNO1GD/bQuwDyHc11/39dd9/fUjwrRUg+PkQBj7SQhYVGLCM241pIwvQUlleMaT8J2Bi6oslTYEVWnj2VcHBwdwdHF8dtbJlVzk+MJypJKzIXdnuYK/wTBIGFriVPXEMzvXemwIm8Ox0j7f3ly+Wrbx+8ZmF0u/0IDL1s+QzNOGg1e+hjiGGeQYFR1HrIdLXSXTpt7BdRbhquYGb7JKiLHU0/y+6Cen529Oj48uT098Wu5Ef0bQ9nXA5nDMJKzQfpgq4hKJHD0GyZNb/59d7rIOl5ucNkKtT9rItkKgUnDj403GNZkYBCMTxm9UAfc5yo0S3QWMds4d+fu0Nrfr8O8TIpeoyX7RTUendgQPdzc41vwO5RhIj/w4JG4IZ/JgyR2iKniaChzD6tMfh8uPEVzyLSEwQcoGKjJKIxSVMLwU2G1HYd/L5ToMZbSSdcETrx9m18Mzintj70ZTpcaMv+vn3g1p4rKiYzmhDTcC4yZAN8rZoeRUZUPJW9LEF9exOrueP0FePfLHDe1xvhj6eycquKiDWx5Zl7yV6l7anYLbC39gGPWzPOjYYdKhUxd9py5U49Sh/c52y/1cYcs3OrAm7xlbXrja52+x8lBhaHZZTeqyu9wqSH3PhECzBVLLHIPyLGtw3VSTQq8GC3WKAXPwW3eXfv2MslCb9tRk9cDgmc1an4EX2+9f4e0FFGrFBUKZK4kh9d/VEnNp9eSd8hFrUCQep+RnJ43wcKndbeXu5XMJTAJLErtft+ipJoPFk/v49ipD9w52hritehJ4+4tf+8LDvvDw31p4eOAtzYg1+cUbFIPdmyz4mRNfCfRpQq0qoFzdDyqvj7jn/uj1EEL4ZBV8zPuA+P4xgR0uclWJ1O5RwyWi/nuyHX3hDC/wJhyoYV8FI9ZE1dzu1W28t22b9I9TeB/HyGeJ7Rix1cbVmbt3h2bQ258Jvvec58WLF9+35zxfz795vitF9d4R9RU1ZH3cgUmn+5+AxT8R24qnZY8x+fdym7bhtdlTpSzRsZIGZXg6F7kXMb6MufgnufP7l8aUP/kT0MPo/PXFZeTfDUaH0eLui0XzLG3RfRm6+K0fwH5ftE9FL2552Up0+q7ExGB64TAdqxSjwy8PDn7/v38BAAD//w==
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using PayPalHttp;


namespace PayoutsSdk.Payouts
{
    /// <summary>
    /// Cancels an unclaimed payout item, by ID. If no one claims the unclaimed item within 30 days, the API automatically returns the funds to the sender. Use this call to cancel the unclaimed item before the automatic 30-day refund. You can cancel payout items with a <code>transaction_status</code> of <code>UNCLAIMED</code>.
    /// </summary>
    public class PayoutsItemCancelRequest : HttpRequest
    {
        public PayoutsItemCancelRequest(string PayoutItemId) : base("/v1/payments/payouts-item/{payout_item_id}/cancel?", HttpMethod.Post, typeof(PayoutItemResponse))
        {
            try {
                this.Path = this.Path.Replace("{payout_item_id}", Uri.EscapeDataString(Convert.ToString(PayoutItemId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        
    }
}
