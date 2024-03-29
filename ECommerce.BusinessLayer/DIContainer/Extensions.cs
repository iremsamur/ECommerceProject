﻿using ECommerce.BusinessLayer.Abstract;
using ECommerce.BusinessLayer.Concrete;
using ECommerce.BusinessLayer.ValidationRules.ItemDetailValidation;
using ECommerce.BusinessLayer.ValidationRules.ItemValidation;
using ECommerce.DataAccessLayer.Abstract;
using ECommerce.DataAccessLayer.EntityFramework;
using ECommerce.DTOLayer.ItemDetailDTO;
using ECommerce.DTOLayer.ItemDTOs;
using FluentValidation;
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
            services.AddScoped<IItemDetailService, ItemDetailManager>();
            services.AddScoped<IItemDetailDal, EfItemDetailDal>();
            services.AddScoped<IItemDetailOwnerService, ItemDetailOwnerManager>();
            services.AddScoped<IItemDetailOwnerDal, EfItemDetailOwnerDal>();

            services.AddScoped<IMessageNotificationService, MessageNotificationManager>();
            services.AddScoped<IMessageNotificationDal, EfMessageNotificationDal>();

            services.AddScoped<INewItemNotificationService, NewItemNotificationManager>();
            services.AddScoped<INewItemNotificationDal, EfNewItemNotificationDal>();


        }
        //Automapper için 
        public static void CustomizeValidator(this IServiceCollection services)
        {
            //DTO ve onun ilgili validator eşleştirmelerini burada yazıp tanımlıyoruz
            services.AddTransient<IValidator<CreateItemDTO>, ItemAddValidator>();
            
            services.AddTransient<IValidator<CreateItemDetailDTO>, ItemDetailAddValidator>();
            //services.AddTransient<IValidator<CreateItemDetailDTO>, ItemDetailAddValidator>();
            //services.AddTransient<IValidator<ContactUpdateDTO>, ContactUpdateValidator>();



        }
    }
}
