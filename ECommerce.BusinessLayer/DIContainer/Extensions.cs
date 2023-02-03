using ECommerce.BusinessLayer.Abstract;
using ECommerce.BusinessLayer.Concrete;
using ECommerce.DataAccessLayer.Abstract;
using ECommerce.DataAccessLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BusinessLayer.DIContainer
{
    public static class Extensions
    {
        public static void Containerdependencies(this IServiceCollection services)
        {
            //Startup içindeki tüm servisleri IServiceCollection'ları burada almak için IServiceCollection'ı veriyoruz.
            //Startup'daki servisler çok fazla olduğu için, business ya da data access layer içinde containerdependencies içinde ServiceCollection burada çağırılır. 
            //Buradaki this ise Bu IServiceCollection'ı kullandığımızı belirtiyor.
            //soyut ve somut sınıflarla yapılan dependency injeksiyonu kullanabilmek için burada bunları tanımlarız
            services.AddScoped<IItemService, ItemManager>();
            services.AddScoped<IItemDal, EfItemDal>();
            services.AddScoped<ISubCategoryService, SubCategoryManager>();
            services.AddScoped<ISubCategoryDal, EfSubCategoryDal>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IUserDal, EfUserDal>();
            services.AddScoped<ICommentService,CommentManager>();
            services.AddScoped<ICommentDal, EfCommentDal>();
            services.AddScoped<IMindListService, MindListManager>();
            services.AddScoped<IMindListDal, EfMindListDal>();
            services.AddScoped<IRoleService, RoleManager>();
            services.AddScoped<IRoleDal, EfRoleDal>();
            services.AddScoped<IBrandService, BrandManager>();
            services.AddScoped<IBrandDal, EfBrandDal>();
            services.AddScoped<IAdItemsService,AdItemsManager>();
            services.AddScoped<IAdItemsDal, EfAdItemsDal>();
            services.AddScoped<IItemOwnerService, ItemOwnerManager>();
            services.AddScoped<IItemOwnerDal, EfItemOwnerDal>();


        }
        //Automapper için 
        public static void CustomizeValidator(this IServiceCollection services)
        {
            //DTO ve onun ilgili validator eşleştirmelerini burada yazıp tanımlıyoruz
            //services.AddTransient<IValidator<ContactAddDTO>, ContactAddValidator>();
            //services.AddTransient<IValidator<ContactUpdateDTO>, ContactUpdateValidator>();



        }
    }
}
