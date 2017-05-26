using System;
using System.Collections.Generic;

namespace PTCData
{
    public class TrainingProductManager
    {
        public TrainingProductManager()
        {
            ValidationErrors = new List<KeyValuePair<string, string>>();
        }
        
        public List<KeyValuePair<string, string>> ValidationErrors { get; set; }

        public bool Validate(TrainingProduct entity)
        {
            ValidationErrors.Clear();

            if (!string.IsNullOrEmpty(entity.ProductName))
            {
                if (entity.ProductName.ToLower() == entity.ProductName)
                {
                    ValidationErrors.Add(new KeyValuePair<string, string>("Product name", "Product name cannot be all lower case."));
                }
            }

            return (ValidationErrors.Count == 0);
        }

        public bool Insert(TrainingProduct entity)
        {
            bool ret = false;

            ret = Validate(entity);
            if (ret)
            {
                //Create insert code here.
            }

            return ret;
        }

        public TrainingProduct Get(int productId)
        {
            List<TrainingProduct> list = new List<TrainingProduct>();
            TrainingProduct ret = new TrainingProduct();

            list = CreateMockData();
            ret = list.Find(p => p.ProductId == productId);

            return ret;
        }

        public bool Delete(TrainingProduct entity)
        {
            // TODO: Create Delete

            return true;
        }

        public bool Update(TrainingProduct entity)
        {
            bool ret = false;

            ret = Validate(entity);
            if (ret)
            {
                //update
            }

            return ret;
        }

        public List<TrainingProduct> Get(TrainingProduct searchEntity)
        {
            List<TrainingProduct> ret = new List<TrainingProduct>();

            ret = CreateMockData();

            if (!string.IsNullOrEmpty(searchEntity.ProductName))
            {
                ret = ret.FindAll(p => p.ProductName.ToLower().StartsWith(searchEntity.ProductName, StringComparison.InvariantCultureIgnoreCase));
            }

            return ret;
        } 

        private List<TrainingProduct> CreateMockData()
        {
            List<TrainingProduct> ret = new List<TrainingProduct>();

            ret.Add(new TrainingProduct()
            {
                ProductId = 1,
                ProductName = "Extending Bootsrap with CSS, Javascript and jQuery",
                IntroductionDate = Convert.ToDateTime("6/11/2017"),
                Url = "http://bit.ly/lSNzc0i",
                Price = Convert.ToDecimal(29.00)
            });
            ret.Add(new TrainingProduct()
            {
                ProductId = 2,
                ProductName = "Build your own Bootstrap Business Application Template in MVC",
                IntroductionDate = Convert.ToDateTime("6/11/2017"),
                Url = "http://bit.ly/lSNzc0i",
                Price = Convert.ToDecimal(29.00)
            });
            ret.Add(new TrainingProduct()
            {
                ProductId = 3,
                ProductName = "Building Mobile Web Sites Using Web Forms, Bootstrap and HTML 5",
                IntroductionDate = Convert.ToDateTime("6/11/2017"),
                Url = "http://bit.ly/lSNzc0i",
                Price = Convert.ToDecimal(29.00)
            });
            ret.Add(new TrainingProduct()
            {
                ProductId = 4,
                ProductName = "How to Start and Run A Consulting Business",
                IntroductionDate = Convert.ToDateTime("6/11/2017"),
                Url = "http://bit.ly/lSNzc0i",
                Price = Convert.ToDecimal(29.00)
            });
            ret.Add(new TrainingProduct()
            {
                ProductId = 5,
                ProductName = "The Many Approaches to XML Processing in .NET Applications",
                IntroductionDate = Convert.ToDateTime("6/11/2017"),
                Url = "http://bit.ly/lSNzc0i",
                Price = Convert.ToDecimal(29.00)
            });
            ret.Add(new TrainingProduct()
            {
                ProductId = 6,
                ProductName = "WPF For The Business Programmer",
                IntroductionDate = Convert.ToDateTime("6/11/2017"),
                Url = "http://bit.ly/lSNzc0i",
                Price = Convert.ToDecimal(29.00)
            });
            ret.Add(new TrainingProduct()
            {
                ProductId = 6,
                ProductName = "WPF For The Visual Basic Programmer - Part 1",
                IntroductionDate = Convert.ToDateTime("6/11/2017"),
                Url = "http://bit.ly/lSNzc0i",
                Price = Convert.ToDecimal(29.00)
            });
            ret.Add(new TrainingProduct()
            {
                ProductId = 7,
                ProductName = "WPF For The Visual Basic Programmer - Part 2",
                IntroductionDate = Convert.ToDateTime("6/11/2017"),
                Url = "http://bit.ly/lSNzc0i",
                Price = Convert.ToDecimal(29.00)
            });

            return ret;
        }          
    }
}