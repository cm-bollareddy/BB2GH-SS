using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Collections;
using System.Linq.Dynamic;

namespace NOLA_MVC4.Models
{
    public class ProgramModelService : IDisposable
    {
        private readonly pdbnolaContext _data = new pdbnolaContext();

        public IEnumerable<nola_programs> getPrograms<T>(
            int currentPage, int programPerPage,
            Expression<Func<nola_programs, bool>> filterBy,
            Expression<Func<nola_programs, T>> orderBy,
            Direction direction)
        {
            if (currentPage < 1) currentPage = 1;
            IQueryable<nola_programs> query = _data.nola_programs;
            if (filterBy != null) query = query.Where(filterBy);
            if (direction == Direction.ASC)
                query = query.OrderBy(orderBy);
            else
                query = query.OrderByDescending(orderBy);

            return query.Skip((currentPage - 1) * programPerPage)
                        .Take(programPerPage)
                        .ToList();
        }

        public IEnumerable<nola_programs> GetProgramPage(int currentPage, int programPerPage, string searchCriteria, string dynamicColumnLinq, string filterCriteria)
        {
            if (currentPage < 1) currentPage = 1;
            return _data.nola_programs
                .Where(dynamicColumnLinq, filterCriteria)
              .OrderBy(searchCriteria)
              .Skip((currentPage - 1) * programPerPage)
              .Take(programPerPage)
              .ToList();
        }

        public nola_programs GetProgramDetails(string NOLACode)
        {
            nola_programs detailedQuery = _data.nola_programs.Find(NOLACode);
            return detailedQuery;
        }

        public int countTotalPrograms()
        {
            return _data.nola_programs.Count();
        }

        public int countFilteredPrograms(
            Expression<Func<nola_programs, bool>> filter)
        {
            IQueryable<nola_programs> query = _data.nola_programs;
            query = query.Where(filter);
            return query.Count();
        }

        public void Dispose()
        {
            _data.Dispose();
        }
    }
    public enum Direction
    {
        ASC,
        DESC
    }
}