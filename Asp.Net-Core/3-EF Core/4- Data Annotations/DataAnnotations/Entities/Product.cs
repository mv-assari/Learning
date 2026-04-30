using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("tblProduct",Schema ="prod")] //برای مشخص کردن نام و شمای جدول در دیتابیس
    public class Product
    {
        public long Id { get; set; }
        [Column(TypeName ="varchar(200)")] //با استفاده از این خاصیت میتوان نوع داده را در دیتابیس مشخص کرد
        public string Name { get; set; }
        
        [NotMapped] //for ignore property or entity when created data base
        public int Price { get; set; }

        [Required]
        [MaxLength(500)]
        [Column("DES")] //برای مشخص کردن نام فیلد در دیتابیس 
        public string Description { get; set; }
    }

    public class Order
    {
        [Key]//برای مشخص کردن کلید 
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //برای اینکه خودمون ای دی رو ایجاد کنید و سمت دیتابیس برای ذخیره ارسال کنیم
        public long KeyId { get; set; }
    }
}
