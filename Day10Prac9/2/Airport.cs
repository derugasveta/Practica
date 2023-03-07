using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Airport : ICollection<Airplane>
    {
        private readonly List<Airplane> _airplanes;

        public Airport(List<Airplane> airplanes)
        {
            _airplanes = airplanes;
        }

        public List<Airplane> Airplanes=>_airplanes;
        public Airport()
        {
            IList<Airplane> airplanes = new List<Airplane>();
        }

        public int Count => _airplanes.Count ;

        public bool IsReadOnly => true;

        public void Add(Airplane plane)
        {
            _airplanes.Add(plane);
        }

        public void Clear()
        {
            _airplanes.Clear();
        }

        public bool Contains(Airplane item)
        {
           return _airplanes.Contains(item) ;
        }

        public void CopyTo(Airplane[] array, int arrayIndex)
        {
            _airplanes.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Airplane> GetEnumerator()
        {
            return _airplanes.GetEnumerator();
        }

        public bool Remove(Airplane item)
        {
            return _airplanes.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _airplanes.GetEnumerator();
        }
    }
}
