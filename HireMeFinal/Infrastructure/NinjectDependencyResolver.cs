using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Moq;
using Ninject;
using HireMeFinal.Abstract;
using HireMeFinal.Models;
using HireMeFinal.Concrete;
using HireMeFinal.Entities;

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
            mock.Setup(m => m.Postings).Returns(new List<Postings> {
                new Postings { jobPostingID = 1, jobTitle = "Job Title 1", jobDescription = "jobDescription 1", companyName = "company 1"},
                new Postings { jobPostingID = 2, jobTitle = "Job Title 2", jobDescription = "jobDescription 2", companyName = "company 2"},
                new Postings { jobPostingID = 3, jobTitle = "Job Title 3", jobDescription = "jobDescription 3", companyName = "company 3"}
                });
            kernel.Bind<IPostingRepository>().ToConstant(mock.Object);

            //kernel.Bind<IPostingRepository>().To<EFPostingRepository>();
        }
    }
}