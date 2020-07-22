using MedicalRecordSystem.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalRecordSystem.Services
{
    public class MedicalHistoryService
    {
        private readonly ApplicationDbContext _db;
        public MedicalHistoryService(ApplicationDbContext db)
        {
            _db = db;
        }
        public MedicalHistory GetMedicalHistory(int MedicalHistoryId)
        {            
            MedicalHistory obj = new MedicalHistory();
            return _db.MedicalHistories.FirstOrDefault(u => u.U_Id == MedicalHistoryId);
        }
        /*public List<MedicalHistory> GetMedicalHistories()
        {
            return _db.MedicalHistories.ToList();
        }*/
        public List<MedicalHistory> GetMedicalHistories(string role,string userId)
        {
			if (!string.Equals(role, "admin", StringComparison.InvariantCultureIgnoreCase))
			{
                return _db.MedicalHistories.Where(h => h.UserId == userId)?.ToList();
            }
            return _db.MedicalHistories.ToList();
        }
        public bool CreateMedicalHistory(MedicalHistory objMedicalHistory)
        {			
            _db.MedicalHistories.Add(objMedicalHistory);
            _db.SaveChanges();
            return true;
        }

        public bool UpdateMedicalHistory(MedicalHistory objMedicalHistory)
        {
            var ExistingMedicalHistory = _db.MedicalHistories.FirstOrDefault(u => u.U_Id == objMedicalHistory.U_Id);
            if (ExistingMedicalHistory != null)
            {
                ExistingMedicalHistory.Name = objMedicalHistory.Name;
                _db.SaveChanges();
            }
            else
            {
                return false;
            }
           
            return true;
        }
        public bool DeleteMedicalHistory(MedicalHistory objMedicalHistory)
        {
            var ExistingMedicalHistory = _db.MedicalHistories.FirstOrDefault(u => u.U_Id == objMedicalHistory.U_Id);
            if (ExistingMedicalHistory != null)
            {
                _db.MedicalHistories.Remove(ExistingMedicalHistory);
                _db.SaveChanges();
            }
            else
            {
                return false;
            }

            return true;
        }
    }
}
