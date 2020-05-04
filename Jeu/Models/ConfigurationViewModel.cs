using BO.Entities;
using BO.Entities.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jeu.Models
{
    public class ConfigurationViewModel
    {

        // éléments à remonter dans la vue :

        // config avec nb de systemes et nb de planetes par systeme

        // liste des types de buildings

        // liste des types de resources

        // ids des types de buildings selectionnés

        // ids des types de resources selectionnées.


        // pour remonter un building : instancier un building pour le plus simple.
        // pour l'identifier : son nom, pas d'"id" en soi => lister les nom => enum?
        // si enum => ids, mais besoin de les lister à la main

        // idem pour les resources => id : la valeur de l'enum, text = attribut name, et identificaton : son appelation.
        public PlanetConfiguration PlanetConfiguration { get; set; }

        public GameConfiguration GameConfiguration { get; set; }


        public List<Resource> ResourcesList { get; set; }

        public List<Building> BuildingsList { get; set; }

        // TODO : la récupération des buildings ne peux se faire par id int, il n'y a pas d'énumération.
        public List<int?> ResourcesEnumListIds { get; set; }

        public List<int?> BuildingEnumListIds { get; set; }



    }
}