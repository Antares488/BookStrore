using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Война и мир", Author = "Л. Толстой", Price = 200 });
            db.Books.Add(new Book { Name = "Отцы и дети", Author = "И. Тургенев", Price = 100 });
            db.Books.Add(new Book { Name = "Чайка", Author = "А. Чехов", Price = 150 });
            db.Books.Add(new Book { Name = "Анна Каренина", Author = "Л. Толстой", Price = 250 });
            db.Books.Add(new Book { Name = "Моби Дик", Author = "Г.Мелвилл", Price = 150 });
            db.Books.Add(new Book { Name = "Преступление и наказание", Author = "Ф. Достоевский", Price = 300 });
            db.Books.Add(new Book { Name = "Мадам Бовари", Author = "Г. Флобер", Price = 150 });
            db.Books.Add(new Book { Name = "Рассказы А. П. Чехова", Author = "А. Чехов", Price = 150 });
            db.Books.Add(new Book { Name = "Мидлмарч", Author = "Д. Элиот", Price = 200 });
            db.Books.Add(new Book { Name = "Большие надежды", Author = "Ч. Диккенс", Price = 150 });
            db.Books.Add(new Book { Name = "Эмма", Author = "Д. Остин", Price = 200 });
            db.Books.Add(new Book { Name = "Великий Гэтсби", Author = "С.Фицджеральд", Price = 250 });


            base.Seed(db);
        }
    }
}