using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Moq;
using Ninject;
using HireMeFinal.Abstract;
using HireMeFinal.Concrete;
using HireMeFinal.Entities;
using jobPosting = HireMeFinal.Models.jobPosting;

namespace HireMeFinal.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            
            Mock<IPostingRepository> mock = new Mock<IPostingRepository>();
            mock.Setup(m => m.Postings).Returns(new List<Models.jobPosting> {
                new jobPosting { jobPostingID = 1, jobTitle = "Job Title 1", jobDescription = "jobDescription 1", companyID = 3},
                new jobPosting { jobPostingID = 2, jobTitle = "Job Title 2", jobDescription = "jobDescription 2", companyID = 4},
                new jobPosting { jobPostingID = 3, jobTitle = "Job Title 3", jobDescription = "jobDescription 3", companyID = 8}
                });
            //kernel.Bind<IPostingRepository>().ToConstant(mock.Object);

            kernel.Bind<IPostingRepository>().To<EFPostingRepository>();
        }
    }
}