using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_12.Models
{
    public class DashboardViewModel
    {
        public List<ProductViewModel> Products { get; set; }
        public List<OrderViewModel> Orders { get; set; }

        public DashboardViewModel()
        {
            Products = new List<ProductViewModel>();
            Orders = new List<OrderViewModel>();
        }

        public void InitList()
        {
            Orders.Add(new OrderViewModel()
            {
                Address = "Rivne Soborna 16",
                CountProduct = 2,
                FullName = "Ameba 1",
                Id = 1,
                NameProduct = "Jaba 1",
                Price = 40000
            });

            Orders.Add(new OrderViewModel()
            {
                Address = "Rivne Soborna 16",
                CountProduct = 2,
                FullName = "Ameba 2",
                Id = 1,
                NameProduct = "Jaba 2",
                Price = 40000
            });

            Orders.Add(new OrderViewModel()
            {
                Address = "Rivne Soborna 16",
                CountProduct = 2,
                FullName = "Ameba 3",
                Id = 1,
                NameProduct = "Jaba 3",
                Price = 40000
            });

            Products.Add(new ProductViewModel()
            {
                Id = 1,
                Name = "Jaba 1",
                Price = 40000,
                Image = "https://lh3.googleusercontent.com/RmHOq1WPLENRTR81Z3DSawRW2ZQiOp-J4VNiwLHrqPkqaNUVQClMUII6NF9N8ffW58UY9QK_hEaN3rWJIwFS6irKA0LnP8V6p9XywNjbQgSeMRZiuiHEOjxbV8imrIMmi178rnlROXxDs3jKOoZWea3lY6Oc4jPz9y9s4-g4cMmlLFw2qFRj4k7zht_HVXAQhGChwrt_ectG0-0A4Vvwl33nvKlPIMKSN-APEplxLJ42I1EBQ0HDqQHezv0fRwkFjPwRwy-hxSdp5LUdZX9aWYeLIk4VN2PzHkjFY5DfaWe2dgSTSqHuecnDdde9Hnk1-3L1wJ2PPImYs5jVgXkxX-UEhK7iloEnRtMlzkfUpmZlqNyRU7bumC_I6mfYvP5JL9W-ywjXW6vK9zsPKiQuzVlsvV-Qa0dRqWmBb3SIl30gxtgT0vuEvHLTwC5VgBywlyHYsTVG1m6VLll2S2lUJVIdY60E2_XdUo89n-n8AQFqz-NLDhFXAHiw3oMJL-df1JZc2Uo22MJEf3uRMn1lIxfjG9N_-OOfrrx5nXvB9zn1zEL1e-ytn1Fzw6Qd7s9ySCz-qfZwGEaNlvzZO47ZhzZzpgoD9WncCQCh5cNECWH1hhPTniiTFwBQbwMjvwUvAFfwS9d8tRi_TTLzpmIYfglw6ZAecmICJi9LFsUnB-Oayg7wqx9eLHXKrq7iqg=w1098-h980-no?authuser=0"
            });

            Products.Add(new ProductViewModel()
            {
                Id = 2,
                Name = "Jaba 2",
                Price = 40000,
                Image = "https://lh3.googleusercontent.com/7WCx5r1Mv2oWoJmZ7PZGL1ku5G5v4iuOYOY7NVP3GXsOfaTAN9qFcpc6jBPSZ5W2Cf6NGp0j0sNksq8bnQL9_X4CEXkWK_H5xvolNLVY7zoDPnE7_Pbo3806ArnR4mIbBLjq6OndHWEtHKstFWHdlg1Lav96HPkXL88_pN1ryHRGQv-iPY9wvYdCwsC6kNuFb-kTaAFa1a2DjpCYDlzrlkbyc2uDd8gom_C0sDrWdBnYSr3zxBcHrv9LEfySuI9UbS5bG8dMGolLCpJm73zRgaPGBcjJ9g9mPRWfiwwf4JLHG-JclJUfNT2XMccPEGpV8gMXyfYYkWjE2CmjCXcNQhHh5RHmXOyBm14lndTYVlTnC_iOk-1mhYGc0-gUqaCqLr6bFWflZOkSZey_j1XdOKPydgdKLxZPjbmZ_Aqs5D1rzy6nU8yhpVD0gF3h7vhPXqxLC_MtEJdVHM-kS0qdG_JONLGJaxB-B2cKusUiypAfOJm5esyXtP7ko5Rin2eEk-oU2nmB2ZU1aVk2dd1n6xdBIBWTZj6nKuP0f17RTixqb3JJDviKKod8qdKWwDD02pIqjaoo3pdatCdQ2W4JoW41kRoMWv7nhem4xNEFqjL0ruzfzK07XYIO-taKCXlqm18hiZj6FaXHqlyvwyA0F9rqHtP_Kl727gCrc9mVeanXxRJD7rI7gOW_lyaGqg=w1528-h980-no?authuser=0"
            });

            Products.Add(new ProductViewModel()
            {
                Id = 3,
                Name = "Jaba 3",
                Price = 40000,
                Image = "https://lh3.googleusercontent.com/pw/ACtC-3e3J113m5O7j0OlGmeKeM4_OUy8-uCjRpv9jJ7K_Hxbd2J9DWs5FPqqJ2g3JMAnD-y-KB6Ap5tyAAOl70KUJzsP-8TI8Y-_5FANZaq4PtHF6Qvv0Qgwc_uxbKcClPtAYKG4L7y2EYefqJvvF25VIzeewkukf2YOzeGuN7EMaQPxYgItP5F0bUBK7abL2Hdhjpfj0_qNZUY1330YEPgrtHvzBLNn9aHnq4UgDySW_2mYya5ONbBKsq8p8nns3SRA7VaKq95jwxN-KOAU-nBMZwIm7yKkNs695pcRTAcbEUn3guErymBwE-I1xaTgoQ8AjE2G4SL0ns0bFiRsmtgdzSJUM1A54alh87b4aUNndWjYk1m_ndCmNRpymqCbo5YywxrvCdajSsKNR8upt-aiWruEbZoemp25m4kUEDaKUlBGjjfY-OaUja1-HMuRXW2vIGexe4Lz6PMAk9RLHYSb7BQ6d237Ly4oVA8a2MP2oPp3-SOyNC0mTAkUAj2X6OlFSrCW0S3LM2osqcfykE7q7uSXLexnB4N0Lp1omBxlsBqJXCUVDUgNL2vJLbvV2bexOFyCnGwhJxjcI1Lzy6xw8WUqqndcDiLdE7rInLyFUY3eJfc3_DS16vLxCRRVI51bC6JhIRmzKq7SssA7tSIarExE96m_GhcocUKQ77RhBwBCEiPjuyXbX6Iid2qAciuZ5WlJ_V0g1pzfeRhUmQsV=w211-h220-no?authuser=0"
            });
        }
    }
}