﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Travel.Api.ConsoleApplication.TravelApiService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TravelApiService.ITravelApiService")]
    public interface ITravelApiService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelApiService/Heartbeat", ReplyAction="http://tempuri.org/ITravelApiService/HeartbeatResponse")]
        Travel.Api.Core.Framework.ServiceResponse<System.DateTime> Heartbeat();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelApiService/Heartbeat", ReplyAction="http://tempuri.org/ITravelApiService/HeartbeatResponse")]
        System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<System.DateTime>> HeartbeatAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelApiService/DistanceMatrix", ReplyAction="http://tempuri.org/ITravelApiService/DistanceMatrixResponse")]
        Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.DistanceMatrixResponse> DistanceMatrix(Travel.Api.Domain.Models.DistanceMatrixRequest distanceMatrixRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelApiService/DistanceMatrix", ReplyAction="http://tempuri.org/ITravelApiService/DistanceMatrixResponse")]
        System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.DistanceMatrixResponse>> DistanceMatrixAsync(Travel.Api.Domain.Models.DistanceMatrixRequest distanceMatrixRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelApiService/Directions", ReplyAction="http://tempuri.org/ITravelApiService/DirectionsResponse")]
        Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.DirectionsResponse> Directions(Travel.Api.Domain.Models.DirectionsRequest directionsRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelApiService/Directions", ReplyAction="http://tempuri.org/ITravelApiService/DirectionsResponse")]
        System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.DirectionsResponse>> DirectionsAsync(Travel.Api.Domain.Models.DirectionsRequest directionsRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelApiService/Elevation", ReplyAction="http://tempuri.org/ITravelApiService/ElevationResponse")]
        Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.ElevationResponse> Elevation(Travel.Api.Domain.Models.ElevationRequest elevationRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelApiService/Elevation", ReplyAction="http://tempuri.org/ITravelApiService/ElevationResponse")]
        System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.ElevationResponse>> ElevationAsync(Travel.Api.Domain.Models.ElevationRequest elevationRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelApiService/Timezone", ReplyAction="http://tempuri.org/ITravelApiService/TimezoneResponse")]
        Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.TimezoneResponse> Timezone(Travel.Api.Domain.Models.TimezoneRequest timezoneRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelApiService/Timezone", ReplyAction="http://tempuri.org/ITravelApiService/TimezoneResponse")]
        System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.TimezoneResponse>> TimezoneAsync(Travel.Api.Domain.Models.TimezoneRequest timezoneRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelApiService/Geocode", ReplyAction="http://tempuri.org/ITravelApiService/GeocodeResponse")]
        Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.GeocodeResponse> Geocode(Travel.Api.Domain.Models.GeocodeRequest geocodeRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelApiService/Geocode", ReplyAction="http://tempuri.org/ITravelApiService/GeocodeResponse")]
        System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.GeocodeResponse>> GeocodeAsync(Travel.Api.Domain.Models.GeocodeRequest geocodeRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelApiService/ReverseGeocode", ReplyAction="http://tempuri.org/ITravelApiService/ReverseGeocodeResponse")]
        Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.GeocodeResponse> ReverseGeocode(Travel.Api.Domain.Models.ReverseGeocodeRequest reverseGeocodeRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelApiService/ReverseGeocode", ReplyAction="http://tempuri.org/ITravelApiService/ReverseGeocodeResponse")]
        System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.GeocodeResponse>> ReverseGeocodeAsync(Travel.Api.Domain.Models.ReverseGeocodeRequest reverseGeocodeRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelApiService/Geolocation", ReplyAction="http://tempuri.org/ITravelApiService/GeolocationResponse")]
        Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.GeolocationResponse> Geolocation(Travel.Api.Domain.Models.GeolocationRequest geolocationRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelApiService/Geolocation", ReplyAction="http://tempuri.org/ITravelApiService/GeolocationResponse")]
        System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.GeolocationResponse>> GeolocationAsync(Travel.Api.Domain.Models.GeolocationRequest geolocationRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelApiService/GetDistanceMatrixRequestHistory", ReplyAction="http://tempuri.org/ITravelApiService/GetDistanceMatrixRequestHistoryResponse")]
        Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.RequestHistory[]> GetDistanceMatrixRequestHistory();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelApiService/GetDistanceMatrixRequestHistory", ReplyAction="http://tempuri.org/ITravelApiService/GetDistanceMatrixRequestHistoryResponse")]
        System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.RequestHistory[]>> GetDistanceMatrixRequestHistoryAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelApiService/GetRequestHistory", ReplyAction="http://tempuri.org/ITravelApiService/GetRequestHistoryResponse")]
        Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.RequestHistory> GetRequestHistory(System.Guid requestId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelApiService/GetRequestHistory", ReplyAction="http://tempuri.org/ITravelApiService/GetRequestHistoryResponse")]
        System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.RequestHistory>> GetRequestHistoryAsync(System.Guid requestId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelApiService/DeleteRequestHistory", ReplyAction="http://tempuri.org/ITravelApiService/DeleteRequestHistoryResponse")]
        Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.DeleteRequestHistoryResponse> DeleteRequestHistory(System.Guid requestId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelApiService/DeleteRequestHistory", ReplyAction="http://tempuri.org/ITravelApiService/DeleteRequestHistoryResponse")]
        System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.DeleteRequestHistoryResponse>> DeleteRequestHistoryAsync(System.Guid requestId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelApiService/ReplayRequest", ReplyAction="http://tempuri.org/ITravelApiService/ReplayRequestResponse")]
        Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.DistanceMatrixResponse> ReplayRequest(System.Guid requestId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITravelApiService/ReplayRequest", ReplyAction="http://tempuri.org/ITravelApiService/ReplayRequestResponse")]
        System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.DistanceMatrixResponse>> ReplayRequestAsync(System.Guid requestId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITravelApiServiceChannel : Travel.Api.ConsoleApplication.TravelApiService.ITravelApiService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TravelApiServiceClient : System.ServiceModel.ClientBase<Travel.Api.ConsoleApplication.TravelApiService.ITravelApiService>, Travel.Api.ConsoleApplication.TravelApiService.ITravelApiService {
        
        public TravelApiServiceClient() {
        }
        
        public TravelApiServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TravelApiServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TravelApiServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TravelApiServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Travel.Api.Core.Framework.ServiceResponse<System.DateTime> Heartbeat() {
            return base.Channel.Heartbeat();
        }
        
        public System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<System.DateTime>> HeartbeatAsync() {
            return base.Channel.HeartbeatAsync();
        }
        
        public Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.DistanceMatrixResponse> DistanceMatrix(Travel.Api.Domain.Models.DistanceMatrixRequest distanceMatrixRequest) {
            return base.Channel.DistanceMatrix(distanceMatrixRequest);
        }
        
        public System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.DistanceMatrixResponse>> DistanceMatrixAsync(Travel.Api.Domain.Models.DistanceMatrixRequest distanceMatrixRequest) {
            return base.Channel.DistanceMatrixAsync(distanceMatrixRequest);
        }
        
        public Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.DirectionsResponse> Directions(Travel.Api.Domain.Models.DirectionsRequest directionsRequest) {
            return base.Channel.Directions(directionsRequest);
        }
        
        public System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.DirectionsResponse>> DirectionsAsync(Travel.Api.Domain.Models.DirectionsRequest directionsRequest) {
            return base.Channel.DirectionsAsync(directionsRequest);
        }
        
        public Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.ElevationResponse> Elevation(Travel.Api.Domain.Models.ElevationRequest elevationRequest) {
            return base.Channel.Elevation(elevationRequest);
        }
        
        public System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.ElevationResponse>> ElevationAsync(Travel.Api.Domain.Models.ElevationRequest elevationRequest) {
            return base.Channel.ElevationAsync(elevationRequest);
        }
        
        public Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.TimezoneResponse> Timezone(Travel.Api.Domain.Models.TimezoneRequest timezoneRequest) {
            return base.Channel.Timezone(timezoneRequest);
        }
        
        public System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.TimezoneResponse>> TimezoneAsync(Travel.Api.Domain.Models.TimezoneRequest timezoneRequest) {
            return base.Channel.TimezoneAsync(timezoneRequest);
        }
        
        public Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.GeocodeResponse> Geocode(Travel.Api.Domain.Models.GeocodeRequest geocodeRequest) {
            return base.Channel.Geocode(geocodeRequest);
        }
        
        public System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.GeocodeResponse>> GeocodeAsync(Travel.Api.Domain.Models.GeocodeRequest geocodeRequest) {
            return base.Channel.GeocodeAsync(geocodeRequest);
        }
        
        public Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.GeocodeResponse> ReverseGeocode(Travel.Api.Domain.Models.ReverseGeocodeRequest reverseGeocodeRequest) {
            return base.Channel.ReverseGeocode(reverseGeocodeRequest);
        }
        
        public System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.GeocodeResponse>> ReverseGeocodeAsync(Travel.Api.Domain.Models.ReverseGeocodeRequest reverseGeocodeRequest) {
            return base.Channel.ReverseGeocodeAsync(reverseGeocodeRequest);
        }
        
        public Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.GeolocationResponse> Geolocation(Travel.Api.Domain.Models.GeolocationRequest geolocationRequest) {
            return base.Channel.Geolocation(geolocationRequest);
        }
        
        public System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.GeolocationResponse>> GeolocationAsync(Travel.Api.Domain.Models.GeolocationRequest geolocationRequest) {
            return base.Channel.GeolocationAsync(geolocationRequest);
        }
        
        public Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.RequestHistory[]> GetDistanceMatrixRequestHistory() {
            return base.Channel.GetDistanceMatrixRequestHistory();
        }
        
        public System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.RequestHistory[]>> GetDistanceMatrixRequestHistoryAsync() {
            return base.Channel.GetDistanceMatrixRequestHistoryAsync();
        }
        
        public Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.RequestHistory> GetRequestHistory(System.Guid requestId) {
            return base.Channel.GetRequestHistory(requestId);
        }
        
        public System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.RequestHistory>> GetRequestHistoryAsync(System.Guid requestId) {
            return base.Channel.GetRequestHistoryAsync(requestId);
        }
        
        public Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.DeleteRequestHistoryResponse> DeleteRequestHistory(System.Guid requestId) {
            return base.Channel.DeleteRequestHistory(requestId);
        }
        
        public System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.DeleteRequestHistoryResponse>> DeleteRequestHistoryAsync(System.Guid requestId) {
            return base.Channel.DeleteRequestHistoryAsync(requestId);
        }
        
        public Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.DistanceMatrixResponse> ReplayRequest(System.Guid requestId) {
            return base.Channel.ReplayRequest(requestId);
        }
        
        public System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.DistanceMatrixResponse>> ReplayRequestAsync(System.Guid requestId) {
            return base.Channel.ReplayRequestAsync(requestId);
        }
    }
}
