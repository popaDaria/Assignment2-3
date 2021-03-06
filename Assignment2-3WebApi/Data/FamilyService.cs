﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2_3WebApi.Models;
using Assignment2_3WebApi.Persistance;

namespace Assignment2_3WebApi.Data
{
    public class FamilyService : IFamilyService
    {

        private FileContext fileContext;

        public FamilyService()
        {
            fileContext = new FileContext();
        }
        
        public async Task<IList<Family>> GetFamiliesAsync()
        {
            IList<Family> families = fileContext.Families;
            return families;
        }

        public async Task AddFamilyAsync(Family newFamily)
        {
            int max = fileContext.Families.Max(family => family.Id);
            newFamily.Id = (++max);
            //check if street+house nr is unique before adding
            if (IsAdressUnique(newFamily))
            {
                fileContext.Families.Add(newFamily);
                fileContext.SaveChanges();
            }
        }

        public async Task<IList<int>> AdultsInFamiliesAsync()
        {
            IList<int> adults = new List<int>();
            foreach (var family in fileContext.Families)
            {
                foreach (var adult in family.Adults)
                {
                    adults.Add(adult.Id);
                }
            }
            return adults;
        }

        public async Task RemoveAdultAsync(int adultId)
        {
            Family familyToRemove = null;
            Adult adult = null;
            foreach (var ad in fileContext.Adults)
            {
                if (ad.Id == adultId)
                {
                    adult = ad;
                }
            }

            if (adult != null)
            {
                foreach (var family in fileContext.Families)
                {
                    if (family.Adults.Contains(adult))
                    {
                        family.Adults.Remove(adult);
                        if (family.Adults.Count == 0)
                            familyToRemove = family;
                        fileContext.SaveChanges();
                    }
                }

                if (familyToRemove != null)
                {
                    fileContext.Families.Remove(familyToRemove);
                    fileContext.SaveChanges();
                }
            }
        }

        private bool IsAdressUnique(Family newFamily)
        {
            IList<Family> families = fileContext.Families;
            bool unique = true;
            foreach (Family fam in families)
            {
                if (fam.HouseNumber == newFamily.HouseNumber && fam.StreetName.Equals(newFamily.StreetName))
                    unique = false;
            }
            return unique;
        }
    }
}