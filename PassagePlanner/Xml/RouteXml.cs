﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.17929.
// 
namespace Seaware.PassagePlanner.Xml {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Route {
        
        private string departurePortField;
        
        private string arrivalPortField;
        
        private string timeZoneDepartureField;
        
        private string timeZoneArrivalField;
        
        private string fileNameField;
        
        private RouteWaypointsWaypoint[][] waypointsField;
        
        private RouteWaypointCollection2Point[][] waypointCollection2Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DeparturePort {
            get {
                return this.departurePortField;
            }
            set {
                this.departurePortField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ArrivalPort {
            get {
                return this.arrivalPortField;
            }
            set {
                this.arrivalPortField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TimeZoneDeparture {
            get {
                return this.timeZoneDepartureField;
            }
            set {
                this.timeZoneDepartureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TimeZoneArrival {
            get {
                return this.timeZoneArrivalField;
            }
            set {
                this.timeZoneArrivalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FileName {
            get {
                return this.fileNameField;
            }
            set {
                this.fileNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Waypoint", typeof(RouteWaypointsWaypoint), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public RouteWaypointsWaypoint[][] Waypoints {
            get {
                return this.waypointsField;
            }
            set {
                this.waypointsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Point", typeof(RouteWaypointCollection2Point), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public RouteWaypointCollection2Point[][] WaypointCollection2 {
            get {
                return this.waypointCollection2Field;
            }
            set {
                this.waypointCollection2Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class RouteWaypointsWaypoint {
        
        private string waypointNameField;
        
        private string speedField;
        
        private string remarksField;
        
        private string minDepthField;
        
        private string chartsField;
        
        private string legReferenceObject_ObjectField;
        
        private string legReferenceObject_BearingField;
        
        private string legReferenceObject_DistanceField;
        
        private string turnRadiusField;
        
        private string turnRateField;
        
        private string landmarkAtCourseAlt_ObjectField;
        
        private string landmarkAtCourseAlt_BearingField;
        
        private string landmarkAtCourseAlt_DistanceField;
        
        private string maxOffTrackField;
        
        private string maxIntervalsPosFixField;
        
        private string engineStatusField;
        
        private string navWatchLevelField;
        
        private string posFixMethodField;
        
        private string listOfLights_VolumeField;
        
        private string listOfLights_PageField;
        
        private string listOfRadioSignals_VolumeField;
        
        private string listOfRadioSignals_PageField;
        
        private string sailingDirections_VolumeField;
        
        private string sailingDirections_PageField;
        
        private string navtexChannelsField;
        
        private string reportToField;
        
        private string channelOrTelephoneNoField;
        
        private string actualPassingTimeField;
        
        private string generalNotesField;
        
        private string unknownField;
        
        private string latitudeField;
        
        private string longitudeField;
        
        private string toolTipField;
        
        private RouteWaypointsWaypointLongLat[] longLatField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string WaypointName {
            get {
                return this.waypointNameField;
            }
            set {
                this.waypointNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Speed {
            get {
                return this.speedField;
            }
            set {
                this.speedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Remarks {
            get {
                return this.remarksField;
            }
            set {
                this.remarksField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MinDepth {
            get {
                return this.minDepthField;
            }
            set {
                this.minDepthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Charts {
            get {
                return this.chartsField;
            }
            set {
                this.chartsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LegReferenceObject_Object {
            get {
                return this.legReferenceObject_ObjectField;
            }
            set {
                this.legReferenceObject_ObjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LegReferenceObject_Bearing {
            get {
                return this.legReferenceObject_BearingField;
            }
            set {
                this.legReferenceObject_BearingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LegReferenceObject_Distance {
            get {
                return this.legReferenceObject_DistanceField;
            }
            set {
                this.legReferenceObject_DistanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TurnRadius {
            get {
                return this.turnRadiusField;
            }
            set {
                this.turnRadiusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TurnRate {
            get {
                return this.turnRateField;
            }
            set {
                this.turnRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LandmarkAtCourseAlt_Object {
            get {
                return this.landmarkAtCourseAlt_ObjectField;
            }
            set {
                this.landmarkAtCourseAlt_ObjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LandmarkAtCourseAlt_Bearing {
            get {
                return this.landmarkAtCourseAlt_BearingField;
            }
            set {
                this.landmarkAtCourseAlt_BearingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LandmarkAtCourseAlt_Distance {
            get {
                return this.landmarkAtCourseAlt_DistanceField;
            }
            set {
                this.landmarkAtCourseAlt_DistanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MaxOffTrack {
            get {
                return this.maxOffTrackField;
            }
            set {
                this.maxOffTrackField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MaxIntervalsPosFix {
            get {
                return this.maxIntervalsPosFixField;
            }
            set {
                this.maxIntervalsPosFixField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string EngineStatus {
            get {
                return this.engineStatusField;
            }
            set {
                this.engineStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NavWatchLevel {
            get {
                return this.navWatchLevelField;
            }
            set {
                this.navWatchLevelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PosFixMethod {
            get {
                return this.posFixMethodField;
            }
            set {
                this.posFixMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ListOfLights_Volume {
            get {
                return this.listOfLights_VolumeField;
            }
            set {
                this.listOfLights_VolumeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ListOfLights_Page {
            get {
                return this.listOfLights_PageField;
            }
            set {
                this.listOfLights_PageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ListOfRadioSignals_Volume {
            get {
                return this.listOfRadioSignals_VolumeField;
            }
            set {
                this.listOfRadioSignals_VolumeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ListOfRadioSignals_Page {
            get {
                return this.listOfRadioSignals_PageField;
            }
            set {
                this.listOfRadioSignals_PageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SailingDirections_Volume {
            get {
                return this.sailingDirections_VolumeField;
            }
            set {
                this.sailingDirections_VolumeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SailingDirections_Page {
            get {
                return this.sailingDirections_PageField;
            }
            set {
                this.sailingDirections_PageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NavtexChannels {
            get {
                return this.navtexChannelsField;
            }
            set {
                this.navtexChannelsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ReportTo {
            get {
                return this.reportToField;
            }
            set {
                this.reportToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ChannelOrTelephoneNo {
            get {
                return this.channelOrTelephoneNoField;
            }
            set {
                this.channelOrTelephoneNoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ActualPassingTime {
            get {
                return this.actualPassingTimeField;
            }
            set {
                this.actualPassingTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string GeneralNotes {
            get {
                return this.generalNotesField;
            }
            set {
                this.generalNotesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Unknown {
            get {
                return this.unknownField;
            }
            set {
                this.unknownField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Latitude {
            get {
                return this.latitudeField;
            }
            set {
                this.latitudeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Longitude {
            get {
                return this.longitudeField;
            }
            set {
                this.longitudeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ToolTip {
            get {
                return this.toolTipField;
            }
            set {
                this.toolTipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LongLat", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RouteWaypointsWaypointLongLat[] LongLat {
            get {
                return this.longLatField;
            }
            set {
                this.longLatField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class RouteWaypointsWaypointLongLat {
        
        private string xField;
        
        private string yField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string X {
            get {
                return this.xField;
            }
            set {
                this.xField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class RouteWaypointCollection2Point {
        
        private string xField;
        
        private string yField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string X {
            get {
                return this.xField;
            }
            set {
                this.xField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class NewDataSet {
        
        private Route[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Route")]
        public Route[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
}
