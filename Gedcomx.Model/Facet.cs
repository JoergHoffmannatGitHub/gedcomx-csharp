using Gedcomx.Model.Util;
using Gx.Types;
// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;

namespace Gx.Records
{

    /// <remarks>
    ///  <p>A <tt>facet</tt> is a logical grouping of resources by specific criteria, used for convenience in browsing a collection or a set of search results.</p>
    /// </remarks>
    /// <summary>
    ///  <p>A <tt>facet</tt> is a logical grouping of resources by specific criteria, used for convenience in browsing a collection or a set of search results.</p>
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gedcomx.org/v1/", TypeName = "Facet")]
    public partial class Facet : Gx.Links.HypermediaEnabledData
    {

        private string _type;
        private string _title;
        private string _key;
        private System.Collections.Generic.List<Gx.Records.Facet> _facets;
        private System.Collections.Generic.List<Gx.Records.FacetValue> _values;
        /// <summary>
        ///  The type of the facet.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "type")]
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }

        /// <summary>
        ///  Convenience property for treating Type as an enum. See Gx.Types.FacetTypeQNameUtil for details on getter/setter functionality.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        [Newtonsoft.Json.JsonIgnore]
        public Gx.Types.FacetType KnownType
        {
            get
            {
                return XmlQNameEnumUtil.GetEnumValue<FacetType>(this._type);
            }
            set
            {
                this._type = XmlQNameEnumUtil.GetNameValue(value);
            }
        }
        /// <summary>
        ///  A title for the facet.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "title", Namespace = "http://gedcomx.org/v1/")]
        [Newtonsoft.Json.JsonProperty("title")]
        public string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                this._title = value;
            }
        }
        /// <summary>
        ///  A key unique within the context of this facet, used to apply the facet.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "key", Namespace = "http://gedcomx.org/v1/")]
        [Newtonsoft.Json.JsonProperty("key")]
        public string Key
        {
            get
            {
                return this._key;
            }
            set
            {
                this._key = value;
            }
        }
        /// <summary>
        ///  The set of sub-facets of this facet.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "facet", Namespace = "http://gedcomx.org/v1/")]
        [Newtonsoft.Json.JsonProperty("facets")]
        public System.Collections.Generic.List<Gx.Records.Facet> Facets
        {
            get
            {
                return this._facets;
            }
            set
            {
                this._facets = value;
            }
        }
        /// <summary>
        ///  The set of values for the field.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "value", Namespace = "http://gedcomx.org/v1/")]
        [Newtonsoft.Json.JsonProperty("values")]
        public System.Collections.Generic.List<Gx.Records.FacetValue> Values
        {
            get
            {
                return this._values;
            }
            set
            {
                this._values = value;
            }
        }
    }
}
