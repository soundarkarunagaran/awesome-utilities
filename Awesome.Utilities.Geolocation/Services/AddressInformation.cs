﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace System.Geolocation.Services
{
    /// <summary>
    ///     Information about an address
    /// </summary>
    [DebuggerDisplay("AddressInformation {ToString()}")]
    public class AddressInformation
    {
        /// <summary>
        /// Gets the components of the address
        /// </summary>
        public AddressInformationComponent[] Components { get; private set; }

        /// <summary>
        /// Gets the type of address this is.
        /// </summary>
        public string Type { get; private set; }

        /// <summary>
        /// Gets the coordinates of the address
        /// </summary>
        public Coordinates Coordinates { get; private set; }

        /// <summary>
        /// Gets the formatted address.
        /// </summary>
        public string FormattedAddress { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressInformation"/> class.
        /// </summary>
        /// <param name="components">The components.</param>
        /// <param name="coordinates">The coordinates.</param>
        /// <param name="formattedAddress">The formatted address.</param>
        /// <param name="type">The type.</param>
        public AddressInformation(AddressInformationComponent[] components, Coordinates coordinates, string formattedAddress, string type)
        {
            this.Components = components;
            this.Coordinates = coordinates;
            this.FormattedAddress = formattedAddress;
            this.Type = type;
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return this.FormattedAddress;
        }

        /// <summary>
        /// Equalses the specified other.
        /// </summary>
        /// <param name="other">The other.</param>
        /// <returns></returns>
        public bool Equals(AddressInformation other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.Components.SequenceEqual(Components) && Equals(other.Type, Type) && other.Coordinates.Equals(Coordinates) && Equals(other.FormattedAddress, FormattedAddress);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof (AddressInformation)) return false;
            return Equals((AddressInformation) obj);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = (Components != null ? Components.GetHashCode() : 0);
                result = (result*397) ^ (Type != null ? Type.GetHashCode() : 0);
                result = (result*397) ^ Coordinates.GetHashCode();
                result = (result*397) ^ (FormattedAddress != null ? FormattedAddress.GetHashCode() : 0);
                return result;
            }
        }
    }
}
