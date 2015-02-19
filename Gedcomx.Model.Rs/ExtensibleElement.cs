using Newtonsoft.Json.Linq;
// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;
using System.Collections.Generic;

namespace Gx.Atom
{

    /// <remarks>
    ///  
    /// </remarks>
    /// <summary>
    ///  
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2005/Atom", TypeName = "ExtensibleElement")]
    public abstract partial class ExtensibleElement : Gx.Atom.CommonAttributes
    {

        private List<Object> _extensionElementsXml;
        private Dictionary<String, JToken> _extensionElementsJson;

        /// <summary>
        ///  Custom extension elements.
        /// </summary>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [Newtonsoft.Json.JsonIgnore]
        public List<Object> ExtensionElementsXml
        {
            get
            {
                return this._extensionElementsXml;
            }
            set
            {
                this._extensionElementsXml = value;
            }
        }

        /// <summary>
        ///  Custom extension elements.
        /// </summary>
        [System.Xml.Serialization.XmlIgnore()]
        [Newtonsoft.Json.JsonExtensionData]
        public Dictionary<String, JToken> ExtensionElementsJson
        {
            get
            {
                return this._extensionElementsJson;
            }
            set
            {
                this._extensionElementsJson = value;
            }
        }

        /**
         * Finds the first extension of a specified type.
         *
         * @param clazz The type.
         * @return The extension, or null if none found.
         */
        public T FindExtensionOfType<T>()
        {
            if (this._extensionElementsXml != null)
            {
                foreach (Object extension in _extensionElementsXml)
                {
                    if (typeof(T).IsAssignableFrom(extension.GetType()))
                    {
                        return (T)extension;
                    }
                }
            }

            if (this._extensionElementsJson != null)
            {
                foreach (JToken extension in _extensionElementsJson.Values)
                {
                    if (extension.Type == JTokenType.Array)
                    {
                        foreach (var item in (JArray)extension)
                        {
                            return item.ToObject<T>();
                        }
                    }
                    else
                    {
                        return extension.ToObject<T>();
                    }
                }
            }

            return default(T);
        }
    }
}
