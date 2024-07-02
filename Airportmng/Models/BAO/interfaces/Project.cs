using Airportmng.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Airportmng.Models.BAO
{
    public interface Project

    {
        //planess
        object fetchAllPlanes();
        string Addplene(Plane_table p);
        Plane_table fetchplaneByID(int id);

        //pilot
        object fetchAllpilots();
        string AddPilot(Pilot_table p);
        Pilot_table fetchpilotByID(int id);

        //manager
        object fetchAllManagers();
        string Addmanagers(ManagerTable p);
        ManagerTable fetchmanagerByID(int id);

        //Addresses
        object fetchAllAddresses();
        string Addaddresses(Addresstable p);
        Addresstable fetchAddressByID(int id);

        //hanger

        object fetchAllHangers();
        string AddHanger(Hanger_table p);
        Hanger_table fetchHangerByID(int id);


        //plane_owner
        object fetchAllPlaneowners();
        string AddPlaneowner(Planeowner_table p);
        object fetchPlaneownerByID(string email);

        //Plane_hanger

        object fetchAllPlane_hanger();
        string AddPlane_hanger(Plane_hanger p);
        Plane_hanger fetchPlane_hangerByID(int id);


    }
}      