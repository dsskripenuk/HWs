using ASP.NET_HW_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_HW_1.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult List()
        {
            List<ProductViewModel> model = new List<ProductViewModel>();
            model.Add(new ProductViewModel()
            {
                Title = "Card title",
                Price = "1000",
                Image = "https://lh3.googleusercontent.com/fife/ABSRlIr9NKglYlkt4PQy1XHxBbUWfc-wlE0VWrFCpDOZo72wSyT3WRRjKLgvCdDuV7Ec4fKq3bByx9h1negwYnpxS8mQjnlg-asVfNJauvRnvdCtJUG1-xAh_qkk7t7pc0tgaelnt9y1yjknWVAAYibLFUJHsZTp5v175k1IxzxGyI-UnetGgyoqY8GLxQJ44kyzYB8rbGIZmWQILP-jx1L9pLEC8glwaE8gNETEH3RhP7UT58WuRQCrma98BOflMM6BprjvJ4cAlox-aO51YH0LDSrisHaitesJeVn7iMqH9Q-GvqY5o9FP1RCAAJdmiB6GxWrFTEaH6kmhtyBGKigw3ns_BjieohnfLltj8T45M0JOlnurT4C3G0Hj9LzswOGqr0whe02oPGXISiRe-VSBTlt2O_oz-_NIwtZRyo8A1iai4ftz1QTKf9nyxARgTcNWWdGlg2I9v7HTAv2WS39dp67RnicgrQO8NU2Et_8UfDSWZz2wGRsIjXOy1cK_xEQ5pS3ROC3tSPcG_VGt2p2i0n6DxcqAIqFuUF5O-QQzWHlXKrP1kG4c2KgpTfQz7Fe26ORhM3FcG40aeeFfoRkMSMf20LFuH0LWyX34Vl5oXtX8klDX1vPYlm_dj7BiTICMJ4QHurfDFCOPbq2Hl-h0dSgmHxUbaMyKgsp4CYyv9i7kvRozT3RNIiyXhe3AFTlqfo_EXYgLe63xLyBlZhFcvuK-xd_b7uR4UW6M6u1tp1GJZw=s1080-w1080-h570-no?authuser=0"
            });

            model.Add(new ProductViewModel()
            {
                Title = "Card title",
                Price = "1000",
                Image = "https://lh3.googleusercontent.com/fife/ABSRlIr9NKglYlkt4PQy1XHxBbUWfc-wlE0VWrFCpDOZo72wSyT3WRRjKLgvCdDuV7Ec4fKq3bByx9h1negwYnpxS8mQjnlg-asVfNJauvRnvdCtJUG1-xAh_qkk7t7pc0tgaelnt9y1yjknWVAAYibLFUJHsZTp5v175k1IxzxGyI-UnetGgyoqY8GLxQJ44kyzYB8rbGIZmWQILP-jx1L9pLEC8glwaE8gNETEH3RhP7UT58WuRQCrma98BOflMM6BprjvJ4cAlox-aO51YH0LDSrisHaitesJeVn7iMqH9Q-GvqY5o9FP1RCAAJdmiB6GxWrFTEaH6kmhtyBGKigw3ns_BjieohnfLltj8T45M0JOlnurT4C3G0Hj9LzswOGqr0whe02oPGXISiRe-VSBTlt2O_oz-_NIwtZRyo8A1iai4ftz1QTKf9nyxARgTcNWWdGlg2I9v7HTAv2WS39dp67RnicgrQO8NU2Et_8UfDSWZz2wGRsIjXOy1cK_xEQ5pS3ROC3tSPcG_VGt2p2i0n6DxcqAIqFuUF5O-QQzWHlXKrP1kG4c2KgpTfQz7Fe26ORhM3FcG40aeeFfoRkMSMf20LFuH0LWyX34Vl5oXtX8klDX1vPYlm_dj7BiTICMJ4QHurfDFCOPbq2Hl-h0dSgmHxUbaMyKgsp4CYyv9i7kvRozT3RNIiyXhe3AFTlqfo_EXYgLe63xLyBlZhFcvuK-xd_b7uR4UW6M6u1tp1GJZw=s1080-w1080-h570-no?authuser=0"
            });

            model.Add(new ProductViewModel()
            {
                Title = "Card title",
                Price = "1000",
                Image = "https://lh3.googleusercontent.com/fife/ABSRlIr9NKglYlkt4PQy1XHxBbUWfc-wlE0VWrFCpDOZo72wSyT3WRRjKLgvCdDuV7Ec4fKq3bByx9h1negwYnpxS8mQjnlg-asVfNJauvRnvdCtJUG1-xAh_qkk7t7pc0tgaelnt9y1yjknWVAAYibLFUJHsZTp5v175k1IxzxGyI-UnetGgyoqY8GLxQJ44kyzYB8rbGIZmWQILP-jx1L9pLEC8glwaE8gNETEH3RhP7UT58WuRQCrma98BOflMM6BprjvJ4cAlox-aO51YH0LDSrisHaitesJeVn7iMqH9Q-GvqY5o9FP1RCAAJdmiB6GxWrFTEaH6kmhtyBGKigw3ns_BjieohnfLltj8T45M0JOlnurT4C3G0Hj9LzswOGqr0whe02oPGXISiRe-VSBTlt2O_oz-_NIwtZRyo8A1iai4ftz1QTKf9nyxARgTcNWWdGlg2I9v7HTAv2WS39dp67RnicgrQO8NU2Et_8UfDSWZz2wGRsIjXOy1cK_xEQ5pS3ROC3tSPcG_VGt2p2i0n6DxcqAIqFuUF5O-QQzWHlXKrP1kG4c2KgpTfQz7Fe26ORhM3FcG40aeeFfoRkMSMf20LFuH0LWyX34Vl5oXtX8klDX1vPYlm_dj7BiTICMJ4QHurfDFCOPbq2Hl-h0dSgmHxUbaMyKgsp4CYyv9i7kvRozT3RNIiyXhe3AFTlqfo_EXYgLe63xLyBlZhFcvuK-xd_b7uR4UW6M6u1tp1GJZw=s1080-w1080-h570-no?authuser=0"
            });

            model.Add(new ProductViewModel()
            {
                Title = "Card title",
                Price = "1000",
                Image = "https://lh3.googleusercontent.com/fife/ABSRlIr9NKglYlkt4PQy1XHxBbUWfc-wlE0VWrFCpDOZo72wSyT3WRRjKLgvCdDuV7Ec4fKq3bByx9h1negwYnpxS8mQjnlg-asVfNJauvRnvdCtJUG1-xAh_qkk7t7pc0tgaelnt9y1yjknWVAAYibLFUJHsZTp5v175k1IxzxGyI-UnetGgyoqY8GLxQJ44kyzYB8rbGIZmWQILP-jx1L9pLEC8glwaE8gNETEH3RhP7UT58WuRQCrma98BOflMM6BprjvJ4cAlox-aO51YH0LDSrisHaitesJeVn7iMqH9Q-GvqY5o9FP1RCAAJdmiB6GxWrFTEaH6kmhtyBGKigw3ns_BjieohnfLltj8T45M0JOlnurT4C3G0Hj9LzswOGqr0whe02oPGXISiRe-VSBTlt2O_oz-_NIwtZRyo8A1iai4ftz1QTKf9nyxARgTcNWWdGlg2I9v7HTAv2WS39dp67RnicgrQO8NU2Et_8UfDSWZz2wGRsIjXOy1cK_xEQ5pS3ROC3tSPcG_VGt2p2i0n6DxcqAIqFuUF5O-QQzWHlXKrP1kG4c2KgpTfQz7Fe26ORhM3FcG40aeeFfoRkMSMf20LFuH0LWyX34Vl5oXtX8klDX1vPYlm_dj7BiTICMJ4QHurfDFCOPbq2Hl-h0dSgmHxUbaMyKgsp4CYyv9i7kvRozT3RNIiyXhe3AFTlqfo_EXYgLe63xLyBlZhFcvuK-xd_b7uR4UW6M6u1tp1GJZw=s1080-w1080-h570-no?authuser=0"
            });

            model.Add(new ProductViewModel()
            {
                Title = "Card title",
                Price = "1000",
                Image = "https://lh3.googleusercontent.com/fife/ABSRlIr9NKglYlkt4PQy1XHxBbUWfc-wlE0VWrFCpDOZo72wSyT3WRRjKLgvCdDuV7Ec4fKq3bByx9h1negwYnpxS8mQjnlg-asVfNJauvRnvdCtJUG1-xAh_qkk7t7pc0tgaelnt9y1yjknWVAAYibLFUJHsZTp5v175k1IxzxGyI-UnetGgyoqY8GLxQJ44kyzYB8rbGIZmWQILP-jx1L9pLEC8glwaE8gNETEH3RhP7UT58WuRQCrma98BOflMM6BprjvJ4cAlox-aO51YH0LDSrisHaitesJeVn7iMqH9Q-GvqY5o9FP1RCAAJdmiB6GxWrFTEaH6kmhtyBGKigw3ns_BjieohnfLltj8T45M0JOlnurT4C3G0Hj9LzswOGqr0whe02oPGXISiRe-VSBTlt2O_oz-_NIwtZRyo8A1iai4ftz1QTKf9nyxARgTcNWWdGlg2I9v7HTAv2WS39dp67RnicgrQO8NU2Et_8UfDSWZz2wGRsIjXOy1cK_xEQ5pS3ROC3tSPcG_VGt2p2i0n6DxcqAIqFuUF5O-QQzWHlXKrP1kG4c2KgpTfQz7Fe26ORhM3FcG40aeeFfoRkMSMf20LFuH0LWyX34Vl5oXtX8klDX1vPYlm_dj7BiTICMJ4QHurfDFCOPbq2Hl-h0dSgmHxUbaMyKgsp4CYyv9i7kvRozT3RNIiyXhe3AFTlqfo_EXYgLe63xLyBlZhFcvuK-xd_b7uR4UW6M6u1tp1GJZw=s1080-w1080-h570-no?authuser=0"
            });

            model.Add(new ProductViewModel()
            {
                Title = "Card title",
                Price = "1000",
                Image = "https://lh3.googleusercontent.com/fife/ABSRlIr9NKglYlkt4PQy1XHxBbUWfc-wlE0VWrFCpDOZo72wSyT3WRRjKLgvCdDuV7Ec4fKq3bByx9h1negwYnpxS8mQjnlg-asVfNJauvRnvdCtJUG1-xAh_qkk7t7pc0tgaelnt9y1yjknWVAAYibLFUJHsZTp5v175k1IxzxGyI-UnetGgyoqY8GLxQJ44kyzYB8rbGIZmWQILP-jx1L9pLEC8glwaE8gNETEH3RhP7UT58WuRQCrma98BOflMM6BprjvJ4cAlox-aO51YH0LDSrisHaitesJeVn7iMqH9Q-GvqY5o9FP1RCAAJdmiB6GxWrFTEaH6kmhtyBGKigw3ns_BjieohnfLltj8T45M0JOlnurT4C3G0Hj9LzswOGqr0whe02oPGXISiRe-VSBTlt2O_oz-_NIwtZRyo8A1iai4ftz1QTKf9nyxARgTcNWWdGlg2I9v7HTAv2WS39dp67RnicgrQO8NU2Et_8UfDSWZz2wGRsIjXOy1cK_xEQ5pS3ROC3tSPcG_VGt2p2i0n6DxcqAIqFuUF5O-QQzWHlXKrP1kG4c2KgpTfQz7Fe26ORhM3FcG40aeeFfoRkMSMf20LFuH0LWyX34Vl5oXtX8klDX1vPYlm_dj7BiTICMJ4QHurfDFCOPbq2Hl-h0dSgmHxUbaMyKgsp4CYyv9i7kvRozT3RNIiyXhe3AFTlqfo_EXYgLe63xLyBlZhFcvuK-xd_b7uR4UW6M6u1tp1GJZw=s1080-w1080-h570-no?authuser=0"
            });

            model.Add(new ProductViewModel()
            {
                Title = "Card title",
                Price = "1000",
                Image = "https://lh3.googleusercontent.com/fife/ABSRlIr9NKglYlkt4PQy1XHxBbUWfc-wlE0VWrFCpDOZo72wSyT3WRRjKLgvCdDuV7Ec4fKq3bByx9h1negwYnpxS8mQjnlg-asVfNJauvRnvdCtJUG1-xAh_qkk7t7pc0tgaelnt9y1yjknWVAAYibLFUJHsZTp5v175k1IxzxGyI-UnetGgyoqY8GLxQJ44kyzYB8rbGIZmWQILP-jx1L9pLEC8glwaE8gNETEH3RhP7UT58WuRQCrma98BOflMM6BprjvJ4cAlox-aO51YH0LDSrisHaitesJeVn7iMqH9Q-GvqY5o9FP1RCAAJdmiB6GxWrFTEaH6kmhtyBGKigw3ns_BjieohnfLltj8T45M0JOlnurT4C3G0Hj9LzswOGqr0whe02oPGXISiRe-VSBTlt2O_oz-_NIwtZRyo8A1iai4ftz1QTKf9nyxARgTcNWWdGlg2I9v7HTAv2WS39dp67RnicgrQO8NU2Et_8UfDSWZz2wGRsIjXOy1cK_xEQ5pS3ROC3tSPcG_VGt2p2i0n6DxcqAIqFuUF5O-QQzWHlXKrP1kG4c2KgpTfQz7Fe26ORhM3FcG40aeeFfoRkMSMf20LFuH0LWyX34Vl5oXtX8klDX1vPYlm_dj7BiTICMJ4QHurfDFCOPbq2Hl-h0dSgmHxUbaMyKgsp4CYyv9i7kvRozT3RNIiyXhe3AFTlqfo_EXYgLe63xLyBlZhFcvuK-xd_b7uR4UW6M6u1tp1GJZw=s1080-w1080-h570-no?authuser=0"
            });

            model.Add(new ProductViewModel()
            {
                Title = "Card title",
                Price = "1000",
                Image = "https://lh3.googleusercontent.com/fife/ABSRlIr9NKglYlkt4PQy1XHxBbUWfc-wlE0VWrFCpDOZo72wSyT3WRRjKLgvCdDuV7Ec4fKq3bByx9h1negwYnpxS8mQjnlg-asVfNJauvRnvdCtJUG1-xAh_qkk7t7pc0tgaelnt9y1yjknWVAAYibLFUJHsZTp5v175k1IxzxGyI-UnetGgyoqY8GLxQJ44kyzYB8rbGIZmWQILP-jx1L9pLEC8glwaE8gNETEH3RhP7UT58WuRQCrma98BOflMM6BprjvJ4cAlox-aO51YH0LDSrisHaitesJeVn7iMqH9Q-GvqY5o9FP1RCAAJdmiB6GxWrFTEaH6kmhtyBGKigw3ns_BjieohnfLltj8T45M0JOlnurT4C3G0Hj9LzswOGqr0whe02oPGXISiRe-VSBTlt2O_oz-_NIwtZRyo8A1iai4ftz1QTKf9nyxARgTcNWWdGlg2I9v7HTAv2WS39dp67RnicgrQO8NU2Et_8UfDSWZz2wGRsIjXOy1cK_xEQ5pS3ROC3tSPcG_VGt2p2i0n6DxcqAIqFuUF5O-QQzWHlXKrP1kG4c2KgpTfQz7Fe26ORhM3FcG40aeeFfoRkMSMf20LFuH0LWyX34Vl5oXtX8klDX1vPYlm_dj7BiTICMJ4QHurfDFCOPbq2Hl-h0dSgmHxUbaMyKgsp4CYyv9i7kvRozT3RNIiyXhe3AFTlqfo_EXYgLe63xLyBlZhFcvuK-xd_b7uR4UW6M6u1tp1GJZw=s1080-w1080-h570-no?authuser=0"
            });

            model.Add(new ProductViewModel()
            {
                Title = "Card title",
                Price = "1000",
                Image = "https://lh3.googleusercontent.com/fife/ABSRlIr9NKglYlkt4PQy1XHxBbUWfc-wlE0VWrFCpDOZo72wSyT3WRRjKLgvCdDuV7Ec4fKq3bByx9h1negwYnpxS8mQjnlg-asVfNJauvRnvdCtJUG1-xAh_qkk7t7pc0tgaelnt9y1yjknWVAAYibLFUJHsZTp5v175k1IxzxGyI-UnetGgyoqY8GLxQJ44kyzYB8rbGIZmWQILP-jx1L9pLEC8glwaE8gNETEH3RhP7UT58WuRQCrma98BOflMM6BprjvJ4cAlox-aO51YH0LDSrisHaitesJeVn7iMqH9Q-GvqY5o9FP1RCAAJdmiB6GxWrFTEaH6kmhtyBGKigw3ns_BjieohnfLltj8T45M0JOlnurT4C3G0Hj9LzswOGqr0whe02oPGXISiRe-VSBTlt2O_oz-_NIwtZRyo8A1iai4ftz1QTKf9nyxARgTcNWWdGlg2I9v7HTAv2WS39dp67RnicgrQO8NU2Et_8UfDSWZz2wGRsIjXOy1cK_xEQ5pS3ROC3tSPcG_VGt2p2i0n6DxcqAIqFuUF5O-QQzWHlXKrP1kG4c2KgpTfQz7Fe26ORhM3FcG40aeeFfoRkMSMf20LFuH0LWyX34Vl5oXtX8klDX1vPYlm_dj7BiTICMJ4QHurfDFCOPbq2Hl-h0dSgmHxUbaMyKgsp4CYyv9i7kvRozT3RNIiyXhe3AFTlqfo_EXYgLe63xLyBlZhFcvuK-xd_b7uR4UW6M6u1tp1GJZw=s1080-w1080-h570-no?authuser=0"
            });

            return View(model);
        }
    }
}