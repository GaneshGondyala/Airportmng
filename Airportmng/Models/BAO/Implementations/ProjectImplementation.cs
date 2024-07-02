using Airportmng.Models.DAO;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;

namespace Airportmng.Models.BAO.Implementations
{
    public class ProjectImplementation :Project
    {
   AirPortDatabaseEntities8 db=new AirPortDatabaseEntities8();  

        //planes
        public object fetchAllPlanes()
        {
            var g = (from w in db.Plane_table
                     select new { w.RegistrationNo, w.ModelNo, w.Plane_Name, w.Capacity, w.Email, w.Plane_Id }).ToList();
            return g;
        }
        public string Addplene(Plane_table p)
        {
            try
            {
                db.Plane_table.Add(p);
                db.SaveChanges();
                return "Plane added success Fully with ID " + p.Plane_Id;
            }
            catch (Exception ex)
            {
                SqlException s = ex.GetBaseException() as SqlException;
                if (s.Message.Contains("PK_Plane_table_1"))
                {
                    return "These Details already exist in Database";
                }
               
                else if (s.Message.Contains("Regiaster_XI"))
                {
                    return "Registation number already Exist";
                }
                else
                {
                    return s.Message;
                }
            }


        }
        public Plane_table fetchplaneByID(int id)
        {
            Plane_table p = (from q in db.Plane_table
                             select q).FirstOrDefault();
            return p;
        }

        //pilot
        public object fetchAllpilots()
        {
            var w = (from q in db.Pilot_table
                     select new { q.License_no, q.SSN, q.DOB, q.Mobile, q.Email, q.AddressId, q.Pilot_Id }).ToList();
            return w;
        }
        public string AddPilot(Pilot_table p)
        {
            try
            {
                db.Pilot_table.Add(p);
                db.SaveChanges();
                return "Pilate added success Fully with ID " + p.Pilot_Id;
            }
            catch (Exception ex)
            {
                SqlException s = ex.GetBaseException() as SqlException;
                if (s.Message.Contains("PK_Pilot_table"))
                {
                    return "These pilot details already exist";
                }
                else if (s.Message.Contains("SSC_con"))
                {
                    return "SSN already Exist to other pilot";
                }


                else if (s.Message.Contains("IX_Pilot_table_1"))
                {
                    return "email already Exist to other pilots";
                }
                else if (s.Message.Contains("Licence"))
                {
                    return "License number already Exist to other pilots";
                }

                else
                {
                    return s.Message;
                }
            }
        }
        public Pilot_table fetchpilotByID(int id)
        {
            Pilot_table p = (from q in db.Pilot_table
                             select q).FirstOrDefault();
            return p;
        }

        //manager
        public object fetchAllManagers()
        {
            var s = (from q in db.ManagerTables
                     select new { q.Name, q.SSN, q.DOB, q.Gender, q.mobile, q.email, q.AddressId, q.ManagerId, q.password });
            return s;
        }
        public string Addmanagers(ManagerTable p)
        {
            string p1 = BCrypt.Net.BCrypt.HashPassword(p.password);
            p.password = p1;
            try
            {
                db.ManagerTables.Add(p);
                db.SaveChanges();
                return "Manager  added success Fully with ID " + p.ManagerId;
            }
            catch (Exception ex)
            {
                SqlException s = ex.GetBaseException() as SqlException;
                if (s.Message.Contains("PK_ManagerTable_1"))
                {
                    return "These details already exist in database";
                }
                else if (s.Message.Contains("SSN_no1"))
                {
                    return "SSN already Exist to other manager";
                }
                else if (s.Message.Contains("IX_ManagerTable_1"))
                {
                    return "Email already Exist to other manager";
                }
                else
                {
                    return s.Message;
                }
            }
        }
        public ManagerTable fetchmanagerByID(int id)
        {
            ManagerTable p = (from q in db.ManagerTables
                              select q).FirstOrDefault();
            return p;
        }

        //Addresses
        public object fetchAllAddresses()
        {
            var q = (from s in db.Addresstables
                     select new { s.Hno, s.Address_line1, s.City, s.state, s.Country, s.pincode, s.AddressId }).ToList();
            return q;

        }
        public string Addaddresses(Addresstable p)
        {
            try
            {
                db.Addresstables.Add(p);
                db.SaveChanges();
                return "Address added success Fully with ID " + p.AddressId;
            }
            catch (Exception ex)
            {
                SqlException s = ex.GetBaseException() as SqlException;
                if (s.Message.Contains("PK_Addresstable_1"))
                {
                    return "Address Id already exist";
                }


                else
                {
                    return s.Message;
                }
            }
        }
        public Addresstable fetchAddressByID(int id)
        {
            Addresstable p = (from q in db.Addresstables
                              select q).FirstOrDefault();
            return p;
        }

        //hanger

        public object fetchAllHangers()
        {
            var q = (from s in db.Hanger_table
                     select new { s.Location, s.Capacity, s.Manager_Id, s.HangerId }).ToList();
            return q;
        }
        public string AddHanger(Hanger_table p)
        {
            try
            {
                db.Hanger_table.Add(p);
                db.SaveChanges();
                return "Hanger added successfully generated ID " + p.HangerId;
            }
            catch (Exception ex)
            {
                SqlException s = ex.GetBaseException() as SqlException;
                if (s.Message.Contains("PK_Hanger_table_1"))
                {
                    return "these hanger details already exist";
                }


                else
                {
                    return s.Message;
                }
            }

        }
        public Hanger_table fetchHangerByID(int id)
        {
            throw new NotImplementedException();
        }


        //plane_owner
        public object fetchAllPlaneowners()
        {
            var q = (from s in db.Planeowner_table
                     select new { s.Email, s.Owner_name, s.address_Id, s.OwnerId }).ToList();
            return q;
        }
        public string AddPlaneowner(Planeowner_table p)
        {
            try
            {
                db.Planeowner_table.Add(p);
                db.SaveChanges();
                return "Plane owner added success Fully with email " + p.Email;
            }
            catch (Exception ex)
            {
                SqlException s = ex.GetBaseException() as SqlException;
                if (s.Message.Contains("PK_Planeowner_table"))
                {
                    return "plane owner already exist with this details";
                }
                else if (s.Message.Contains("IX_Planeowner_table"))
                {
                    return "OwnerID already Exist to other owner";
                }

                else
                {
                    return s.Message;
                }
            }
        }
        public object fetchPlaneownerByID(string email)
        {
            var query = from t1 in db.Planeowner_table
                        join t2 in db.Addresstables on t1.address_Id equals t2.AddressId
                        where t1.Email == email
                        select new
                        {
                            t1.Owner_name,
                            t2.Hno,
                            t2.Address_line1,
                            t2.City,
                            t2.state,
                            t2.Country,
                            t2.pincode
                        };
            return query;
        }

        //Plane_hanger

        public object fetchAllPlane_hanger()
        {
            var q = (from s in db.Plane_hanger
                     select new { s.Plane_Id, s.Hanger_Id, s.fromdate, s.todate, s.ID }).ToList();
            return q;

        }
        public string AddPlane_hanger(Plane_hanger p)
        {

            db.Plane_hanger.Add(p);
            db.SaveChanges();
            return "HAnger_ID: "+ p.Hanger_Id +"Allocated to plane ID: "+p.Plane_Id+"  from  "+p.fromdate+"  TO "+p.todate;
        }
        public Plane_hanger fetchPlane_hangerByID(int id)
        {
            throw new NotImplementedException();
        }


        public bool ValidateAdmin(string UsernameAdmin, string PasswordAdmin)
        {
            var v = (from V1 in db.Admintables
                    where V1.Username == UsernameAdmin && V1.Password == PasswordAdmin
                     select V1).FirstOrDefault();
            if(v==null)
                return false;
            else
                return true;
        
        }
        public bool ValidateManager(string Usernamemgr, string Passwordmgr)
        {

           
            var v = (from V1 in db.ManagerTables
                     where V1.ManagerId == Usernamemgr 
                     select V1).FirstOrDefault();
            if (v == null)
                return false;
            else 
            {
                return (BCrypt.Net.BCrypt.Verify(Passwordmgr, v.password));
                 
            } 
              

        }


    }
}