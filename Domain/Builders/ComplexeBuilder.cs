using Domain.Entities;
using Domain.Exceptions;
using Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Builders
{
    // TODO to intrafra, ComplexeCatalog,  ??? 
    public class ComplexeBuilder
    {
        private readonly List<Housing> _housings = new List<Housing>();

        public ComplexeBuilder NewHousing(string name)
        {
            _housings.Add(new Housing(name));
            return this;
        }

        public ComplexeBuilder AddRoom(Room room)
        {
            _housings.Last().NewRoom(room);
            return this;
        }

        private Complexe Build()
        {
            return new Complexe(_housings);
        }

        public static implicit operator Complexe(ComplexeBuilder builder)
        {
            builder.Validate();
            return builder.Build();
        }

        private void Validate()
        {
            if (_housings == null)
                throw new NullReferenceException();
            if (!_housings.Any())
                throw new EmptyException(nameof(_housings));
        }
    }
}
