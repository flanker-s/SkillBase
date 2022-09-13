﻿using Microsoft.EntityFrameworkCore;
using SkillBase.Data;
using SkillBase.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillBase.Extensions
{
    internal static class MainDbContextExtensions
    {
        public static List<Skill> GetTrees(this MainDbContext context)
        {
            var skills = context.Skills.ToList();
            return skills.Where(x => x.Parent == null).ToList();
        }
        public static async Task<List<Skill>> GetTreesAsync(this MainDbContext context)
        {
            var skills = await context.Skills.Include(x=>x.Links).ToListAsync();
            return skills.Where(x => x.Parent == null).ToList();
        }
    }
}
