﻿/*  
  plmOS Design provides a .NET library that defines Item Types for managing Design data.

  Copyright (C) 2015 Processwall Limited.

  This program is free software: you can redistribute it and/or modify
  it under the terms of the GNU Affero General Public License as published
  by the Free Software Foundation, either version 3 of the License, or
  (at your option) any later version.

  This program is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU Affero General Public License for more details.

  You should have received a copy of the GNU Affero General Public License
  along with this program.  If not, see http://opensource.org/licenses/AGPL-3.0.
 
  Company: Processwall Limited
  Address: The Winnowing House, Mill Lane, Askham Richard, York, YO23 3NW, United Kingdom
  Tel:     +44 113 815 3440
  Email:   support@processwall.com
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plmOS.Design
{
    public class Part : Model.Item
    {
        [Model.PropertyAttributes.StringProperty(true, false, 32)]
        public String Number { get; set; }

        [Model.PropertyAttributes.StringProperty(true, false, 32)]
        public String Revision { get; set; }

        [Model.PropertyAttributes.StringProperty(false, false, 256)]
        public String Name { get; set; }

        [Model.PropertyAttributes.DateTimeProperty(false, false)]
        public DateTime Created { get; set; }

        [Model.PropertyAttributes.DateTimeProperty(false, false)]
        public DateTime Modified { get; set; }

        [Model.PropertyAttributes.BooleanProperty(false, false)]
        public Boolean Released { get; set; }

        [Model.PropertyAttributes.ListProperty(false, false)]
        public PartTypes Type { get; private set; }

        public Part(Model.Session Session)
            : base(Session)
        {
            this.Type = new PartTypes();
        }

        public Part(Model.Session Session, Database.IItem DatabaseItem)
            : base(Session, DatabaseItem)
        {
            this.Type = new PartTypes();
            this.Initialise(DatabaseItem);
        }
    }
}
