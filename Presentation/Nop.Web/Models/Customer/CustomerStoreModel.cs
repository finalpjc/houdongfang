﻿using System.Web.Mvc;
using FluentValidation.Attributes;
using Nop.Web.Framework;
using Nop.Web.Framework.Mvc;
using Nop.Web.Validators.Customer;
using System.Web;

namespace Nop.Web.Models.Customer
{
    [Validator(typeof(CustomerStoreValidator))]
    public partial class CustomerStoreModel : BaseNopModel
    {
        [NopResourceDisplayName("Account.Fields.FirstName")]
        [AllowHtml]
        public string FirstName { get; set; }

        [NopResourceDisplayName("Account.Fields.LastName")]
        [AllowHtml]
        public string LastName { get; set; }

        [NopResourceDisplayName("Account.Fields.Phone")]
        [AllowHtml]
        public string Phone { get; set; }

        [NopResourceDisplayName("Account.Fields.IdCardNo")]
        [AllowHtml]
        public string IdCardNo { get; set; }

        [NopResourceDisplayName("Account.Fields.CollegeName")]
        [AllowHtml]
        public string CollegeName { get; set; }

        [NopResourceDisplayName("Account.Fields.StudentId")]
        [AllowHtml]
        public string StudentId { get; set; }

        [NopResourceDisplayName("Account.Fields.DocumentCopyUrl")]
        public string DocumentCopyUrl { get; set; }

        [NopResourceDisplayName("Account.Fields.StoreName")]
        [AllowHtml]
        public string StoreName { get; set; }

        [NopResourceDisplayName("Account.Fields.StoreDescription")]
        [AllowHtml]
        public string StoreDescription { get; set; }

        [NopResourceDisplayName("Account.Fields.AlipayAccount")]
        [AllowHtml]
        public string AlipayAccount { get; set; }

        public CustomerNavigationModel NavigationModel { get; set; }

        public CustomerApplyStoreEnum ApplyStoreState { get; set; }
    }
}