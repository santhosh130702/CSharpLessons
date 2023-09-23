﻿using Microsoft.EntityFrameworkCore;

namespace MVCefapp.Models
{
    public class RepositoryPatient
    {
        public static List<Patient> GetPatient()
        {
            HospitalDbContext ctx = new HospitalDbContext();
            var list = ctx.Patients.ToList();
            return list;
        }
        public static Patient GetPatientById(int id)
        {
            HospitalDbContext db = new HospitalDbContext();
            var doctor = db.Patients.Find(id);
            return doctor;
        }
        public static void AddNewPatient(Patient patient)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Patients.Add(patient);
            ctx.SaveChanges();
        }
        public static void ModifyPatient(Patient patient)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Entry(patient).State = EntityState.Modified;
            ctx.SaveChanges();
        }
        public static void RemovePatient(int id)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            Patient patient = ctx.Patients.Find(id);
            ctx.Patients.Remove(patient);
            ctx.SaveChanges();





        }
    }
}
