//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Script
{
    using System;
    using System.Xml;
    using System.Xml.Schema;
    using System.Collections.Generic;
    using HP.ST.Fwk.RunTimeFWK;
    using HP.ST.Fwk.RunTimeFWK.CheckpointFWK;
    using HP.ST.Fwk.RunTimeFWK.Utilities;
    using HP.ST.Ext.CheckpointLogicOperators;
    using HP.ST.Ext.BindingImpl.Getters;
    using HP.ST.Ext.BindingImpl.Setters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Getters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Setters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.PropInfo;
    using HP.ST.Ext.CheckpointRules;
    using HP.ST.Ext.CheckpointRules.ArrayCheckpoints;
    
    
    public partial class WorkFlowScript
    {
        
        private void set_StServiceCallActivity18_checkpoints(STActivityBase activity)
        {
            VTDPropertyInfoBase stracturalOutputEnvelope = new VTDPropertyInfoBase("OutputEnvelope", "/*[local-name(.)=\'Envelope\'][1]");
            IList<VTDPropertyInfoBase> stracturalPropsInfo = new List<VTDPropertyInfoBase>();
            CpValObj ExpectedSchema = new CpValObj("<?xml version=\"1.0\" encoding=\"utf-16\"?><xs:schema xmlns=\"http://schemas.xmlsoap.o" +
                    "rg/soap/envelope/\" xmlns:vtd=\"hp.visual_test_designer\" elementFormDefault=\"quali" +
                    "fied\" targetNamespace=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:xs=\"http" +
                    "://www.w3.org/2001/XMLSchema\"><xs:import schemaLocation=\"EmbeddedResources/Fligh" +
                    "ts_SO\\webServices\\Flights_SO\\_5.xsd\" namespace=\"HP.SOAQ.SampleApp/Imports\" /><xs" +
                    ":attribute name=\"fullName\" type=\"xs:string\" /><xs:attribute name=\"group\" type=\"x" +
                    "s:string\" /><xs:attribute name=\"serialize\" type=\"xs:string\" /><xs:attribute name" +
                    "=\"argType\" type=\"xs:string\" /><xs:element name=\"Envelope\" type=\"Envelope\" /><xs:" +
                    "complexType name=\"Envelope\"><xs:sequence><xs:element minOccurs=\"0\" ref=\"Header\" " +
                    "/><xs:element minOccurs=\"1\" ref=\"Body\" /></xs:sequence><xs:anyAttribute processC" +
                    "ontents=\"lax\" /></xs:complexType><xs:element name=\"Header\" type=\"Header\" /><xs:c" +
                    "omplexType name=\"Header\"><xs:sequence xmlns=\"\"><xs:any minOccurs=\"0\" maxOccurs=\"" +
                    "unbounded\" processContents=\"lax\" /></xs:sequence><xs:anyAttribute processContent" +
                    "s=\"lax\" /></xs:complexType><xs:element name=\"Body\" type=\"Body\" /><xs:complexType" +
                    " name=\"Body\"><xs:sequence xmlns=\"\"><xs:element xmlns:q1=\"HP.SOAQ.SampleApp\" ref=" +
                    "\"q1:GetFlightsResponse\" /></xs:sequence><xs:anyAttribute namespace=\"##any\" proce" +
                    "ssContents=\"lax\"><xs:annotation><xs:documentation>Prose in the spec does not spe" +
                    "cify that attributes are allowed on the Body element</xs:documentation></xs:anno" +
                    "tation></xs:anyAttribute></xs:complexType><xs:attribute name=\"mustUnderstand\"><x" +
                    "s:simpleType><xs:restriction base=\"xs:boolean\"><xs:pattern value=\"0|1\" /></xs:re" +
                    "striction></xs:simpleType></xs:attribute><xs:attribute name=\"actor\" type=\"xs:any" +
                    "URI\" /><xs:simpleType name=\"encodingStyle\"><xs:annotation><xs:documentation>\'enc" +
                    "odingStyle\' indicates any canonicalization conventions followed in the contents " +
                    "of the containing element.  For example, the value \'http://schemas.xmlsoap.org/s" +
                    "oap/encoding/\' indicates the pattern described in SOAP specification</xs:documen" +
                    "tation></xs:annotation><xs:list itemType=\"xs:anyURI\" /></xs:simpleType><xs:attri" +
                    "bute name=\"encodingStyle\" type=\"encodingStyle\" /><xs:attributeGroup name=\"encodi" +
                    "ngStyle\"><xs:attribute ref=\"encodingStyle\" /></xs:attributeGroup><xs:element nam" +
                    "e=\"Fault\" type=\"Fault\" /><xs:complexType name=\"Fault\" final=\"extension\"><xs:anno" +
                    "tation><xs:documentation>Fault reporting structure</xs:documentation></xs:annota" +
                    "tion><xs:sequence><xs:element name=\"faultcode\" type=\"xs:QName\" /><xs:element nam" +
                    "e=\"faultstring\" type=\"xs:string\" /><xs:element minOccurs=\"0\" name=\"faultactor\" t" +
                    "ype=\"xs:anyURI\" /><xs:element minOccurs=\"0\" name=\"detail\" type=\"detail\" /></xs:s" +
                    "equence></xs:complexType><xs:complexType name=\"detail\"><xs:sequence><xs:any minO" +
                    "ccurs=\"0\" maxOccurs=\"unbounded\" namespace=\"##any\" processContents=\"lax\" /></xs:s" +
                    "equence><xs:anyAttribute namespace=\"##any\" processContents=\"lax\" /></xs:complexT" +
                    "ype></xs:schema>", XmlTypeCode.None);
            stracturalPropsInfo.Add(stracturalOutputEnvelope);
            BaseCPRule StracturalRule = new StracturalRule(activity, ExpectedSchema, stracturalPropsInfo);
            activity.AddCheckpointRule(StracturalRule);

        }
        
        private void set_StServiceCallActivity21_checkpoints(STActivityBase activity)
        {
            VTDPropertyInfoBase stracturalOutputEnvelope = new VTDPropertyInfoBase("OutputEnvelope", "/*[local-name(.)=\'Envelope\'][1]");
            IList<VTDPropertyInfoBase> stracturalPropsInfo = new List<VTDPropertyInfoBase>();
            CpValObj ExpectedSchema = new CpValObj("<?xml version=\"1.0\" encoding=\"utf-16\"?><xs:schema xmlns=\"http://schemas.xmlsoap.o" +
                    "rg/soap/envelope/\" xmlns:vtd=\"hp.visual_test_designer\" elementFormDefault=\"quali" +
                    "fied\" targetNamespace=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:xs=\"http" +
                    "://www.w3.org/2001/XMLSchema\"><xs:import schemaLocation=\"EmbeddedResources/Fligh" +
                    "ts_SO\\webServices\\Flights_SO\\_5.xsd\" namespace=\"HP.SOAQ.SampleApp/Imports\" /><xs" +
                    ":attribute name=\"fullName\" type=\"xs:string\" /><xs:attribute name=\"group\" type=\"x" +
                    "s:string\" /><xs:attribute name=\"serialize\" type=\"xs:string\" /><xs:attribute name" +
                    "=\"argType\" type=\"xs:string\" /><xs:element name=\"Envelope\" type=\"Envelope\" /><xs:" +
                    "complexType name=\"Envelope\"><xs:sequence><xs:element minOccurs=\"0\" ref=\"Header\" " +
                    "/><xs:element minOccurs=\"1\" ref=\"Body\" /></xs:sequence><xs:anyAttribute processC" +
                    "ontents=\"lax\" /></xs:complexType><xs:element name=\"Header\" type=\"Header\" /><xs:c" +
                    "omplexType name=\"Header\"><xs:sequence xmlns=\"\"><xs:any minOccurs=\"0\" maxOccurs=\"" +
                    "unbounded\" processContents=\"lax\" /></xs:sequence><xs:anyAttribute processContent" +
                    "s=\"lax\" /></xs:complexType><xs:element name=\"Body\" type=\"Body\" /><xs:complexType" +
                    " name=\"Body\"><xs:sequence xmlns=\"\"><xs:element xmlns:q1=\"HP.SOAQ.SampleApp\" ref=" +
                    "\"q1:CreateFlightOrderResponse\" /></xs:sequence><xs:anyAttribute namespace=\"##any" +
                    "\" processContents=\"lax\"><xs:annotation><xs:documentation>Prose in the spec does " +
                    "not specify that attributes are allowed on the Body element</xs:documentation></" +
                    "xs:annotation></xs:anyAttribute></xs:complexType><xs:attribute name=\"mustUnderst" +
                    "and\"><xs:simpleType><xs:restriction base=\"xs:boolean\"><xs:pattern value=\"0|1\" />" +
                    "</xs:restriction></xs:simpleType></xs:attribute><xs:attribute name=\"actor\" type=" +
                    "\"xs:anyURI\" /><xs:simpleType name=\"encodingStyle\"><xs:annotation><xs:documentati" +
                    "on>\'encodingStyle\' indicates any canonicalization conventions followed in the co" +
                    "ntents of the containing element.  For example, the value \'http://schemas.xmlsoa" +
                    "p.org/soap/encoding/\' indicates the pattern described in SOAP specification</xs:" +
                    "documentation></xs:annotation><xs:list itemType=\"xs:anyURI\" /></xs:simpleType><x" +
                    "s:attribute name=\"encodingStyle\" type=\"encodingStyle\" /><xs:attributeGroup name=" +
                    "\"encodingStyle\"><xs:attribute ref=\"encodingStyle\" /></xs:attributeGroup><xs:elem" +
                    "ent name=\"Fault\" type=\"Fault\" /><xs:complexType name=\"Fault\" final=\"extension\"><" +
                    "xs:annotation><xs:documentation>Fault reporting structure</xs:documentation></xs" +
                    ":annotation><xs:sequence><xs:element name=\"faultcode\" type=\"xs:QName\" /><xs:elem" +
                    "ent name=\"faultstring\" type=\"xs:string\" /><xs:element minOccurs=\"0\" name=\"faulta" +
                    "ctor\" type=\"xs:anyURI\" /><xs:element minOccurs=\"0\" name=\"detail\" type=\"detail\" /" +
                    "></xs:sequence></xs:complexType><xs:complexType name=\"detail\"><xs:sequence><xs:a" +
                    "ny minOccurs=\"0\" maxOccurs=\"unbounded\" namespace=\"##any\" processContents=\"lax\" /" +
                    "></xs:sequence><xs:anyAttribute namespace=\"##any\" processContents=\"lax\" /></xs:c" +
                    "omplexType></xs:schema>", XmlTypeCode.None);
            stracturalPropsInfo.Add(stracturalOutputEnvelope);
            BaseCPRule StracturalRule = new StracturalRule(activity, ExpectedSchema, stracturalPropsInfo);
            activity.AddCheckpointRule(StracturalRule);

        }
    }
}
