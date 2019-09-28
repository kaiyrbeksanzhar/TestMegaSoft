using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MegaSoft1.Models.Entites;

namespace MegaSoft1.Models.Additional
{
    //Это полностью реализация анкетирование персонала(Сохранить,Изменить,Удалить)
    public partial class PeronalDatePanelRepository
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public PeronalDatePanelRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        //Добавляет в базу данные персонала
        public bool Insert(PersonalDateCreateMdl model)
        {
            db.Configuration.AutoDetectChangesEnabled = false;
            try
            {
                PersonalDate personalDate = new PersonalDate()
                {
                    Name = model.Name,
                    Age = model.Age,
                    Birthday = model.Birthday,
                    Gender = model.Gender,
                    LoveToProgram = model.LoveToProgram,
                    MaritalStatus = model.MaritalStatus,
                };
                db.personalDates.Add(personalDate);
                db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }
        //возвращает лист персонала
        public List<PersonalViewListMdl> personalListMdl()
        {
            //Отключаю ленивую загрузку
            db.Configuration.LazyLoadingEnabled = false;
            //Проверка если модел нет то пустым отправляет
            var model = (from pd in db.personalDates

                         select new PersonalViewListMdl
                         {
                             Id = pd.Id,
                             Name = pd.Name,
                             Birthday = pd.Birthday,
                         }).ToList();
            return model;
        }

        public bool Delete(int id)
        {
            try
            {
                var model = db.personalDates.Find(id);
                db.personalDates.Remove(model);
                db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public PersonalDetailsViewMdl getDetailsPersonal(int id)
        {
            db.Configuration.LazyLoadingEnabled = false;
            var result = (from pd in db.personalDates

                          where pd.Id == id
                          select new PersonalDetailsViewMdl
                          {
                              Id = pd.Id,
                              Name = pd.Name,
                              Age = pd.Age,
                              Birthday = pd.Birthday,
                              Gender = pd.Gender,
                              LoveToProgram = pd.LoveToProgram,
                              MaritalStatus = pd.MaritalStatus,
                          }).SingleOrDefault();
            return result;
        }
    }
}