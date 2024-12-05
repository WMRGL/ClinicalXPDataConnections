﻿using ClinicalXPDataConnections.Data;
using ClinicalXPDataConnections.Models;

namespace ClinicalXPDataConnections.Meta
{

    public interface IRelativeDiaryData
    {
        public List<RelativeDiary> GetRelativeDiaryList(int relID);
    }
    public class RelativeDiaryData : IRelativeDiaryData
    {
        private readonly ClinicalContext _context;

        public RelativeDiaryData(ClinicalContext context)
        {
            _context = context;
        }

        public List<RelativeDiary> GetRelativeDiaryList(int relID)
        {
            IQueryable<RelativeDiary> diaryList = _context.RelativesDiary.Where(d => d.RelsID == relID);

            return diaryList.ToList();
        }
    }
}