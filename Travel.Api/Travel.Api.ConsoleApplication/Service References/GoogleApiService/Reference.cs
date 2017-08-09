﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Travel.Api.ConsoleApplication.GoogleApiService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GoogleApiService.IGoogleApiService")]
    public interface IGoogleApiService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGoogleApiService/Heartbeat", ReplyAction="http://tempuri.org/IGoogleApiService/HeartbeatResponse")]
        Travel.Api.Core.Framework.ServiceResponse<System.DateTime> Heartbeat();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGoogleApiService/Heartbeat", ReplyAction="http://tempuri.org/IGoogleApiService/HeartbeatResponse")]
        System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<System.DateTime>> HeartbeatAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGoogleApiService/DistanceMatrix", ReplyAction="http://tempuri.org/IGoogleApiService/DistanceMatrixResponse")]
        Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.DistanceMatrixResponse> DistanceMatrix(Travel.Api.Domain.Models.DistanceMatrixRequest distanceMatrixRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGoogleApiService/DistanceMatrix", ReplyAction="http://tempuri.org/IGoogleApiService/DistanceMatrixResponse")]
        System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.DistanceMatrixResponse>> DistanceMatrixAsync(Travel.Api.Domain.Models.DistanceMatrixRequest distanceMatrixRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGoogleApiService/Directions", ReplyAction="http://tempuri.org/IGoogleApiService/DirectionsResponse")]
        Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.DirectionsResponse> Directions(Travel.Api.Domain.Models.DirectionsRequest directionsRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGoogleApiService/Directions", ReplyAction="http://tempuri.org/IGoogleApiService/DirectionsResponse")]
        System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.DirectionsResponse>> DirectionsAsync(Travel.Api.Domain.Models.DirectionsRequest directionsRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGoogleApiService/Elevation", ReplyAction="http://tempuri.org/IGoogleApiService/ElevationResponse")]
        Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.ElevationResponse> Elevation(Travel.Api.Domain.Models.ElevationRequest elevationRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGoogleApiService/Elevation", ReplyAction="http://tempuri.org/IGoogleApiService/ElevationResponse")]
        System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.ElevationResponse>> ElevationAsync(Travel.Api.Domain.Models.ElevationRequest elevationRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGoogleApiService/Timezone", ReplyAction="http://tempuri.org/IGoogleApiService/TimezoneResponse")]
        Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.TimezoneResponse> Timezone(Travel.Api.Domain.Models.TimezoneRequest timezoneRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGoogleApiService/Timezone", ReplyAction="http://tempuri.org/IGoogleApiService/TimezoneResponse")]
        System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.TimezoneResponse>> TimezoneAsync(Travel.Api.Domain.Models.TimezoneRequest timezoneRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGoogleApiService/Geocode", ReplyAction="http://tempuri.org/IGoogleApiService/GeocodeResponse")]
        Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.GeocodeResponse> Geocode(Travel.Api.Domain.Models.GeocodeRequest geocodeRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGoogleApiService/Geocode", ReplyAction="http://tempuri.org/IGoogleApiService/GeocodeResponse")]
        System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.GeocodeResponse>> GeocodeAsync(Travel.Api.Domain.Models.GeocodeRequest geocodeRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGoogleApiService/GetDistanceMatrixRequestHistory", ReplyAction="http://tempuri.org/IGoogleApiService/GetDistanceMatrixRequestHistoryResponse")]
        Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.RequestHistory[]> GetDistanceMatrixRequestHistory();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGoogleApiService/GetDistanceMatrixRequestHistory", ReplyAction="http://tempuri.org/IGoogleApiService/GetDistanceMatrixRequestHistoryResponse")]
        System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.RequestHistory[]>> GetDistanceMatrixRequestHistoryAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGoogleApiService/GetRequestHistory", ReplyAction="http://tempuri.org/IGoogleApiService/GetRequestHistoryResponse")]
        Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.RequestHistory> GetRequestHistory(System.Guid requestId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGoogleApiService/GetRequestHistory", ReplyAction="http://tempuri.org/IGoogleApiService/GetRequestHistoryResponse")]
        System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.RequestHistory>> GetRequestHistoryAsync(System.Guid requestId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGoogleApiService/DeleteRequestHistory", ReplyAction="http://tempuri.org/IGoogleApiService/DeleteRequestHistoryResponse")]
        Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.DeleteRequestHistoryResponse> DeleteRequestHistory(System.Guid requestId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGoogleApiService/DeleteRequestHistory", ReplyAction="http://tempuri.org/IGoogleApiService/DeleteRequestHistoryResponse")]
        System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.DeleteRequestHistoryResponse>> DeleteRequestHistoryAsync(System.Guid requestId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGoogleApiService/ReplayRequest", ReplyAction="http://tempuri.org/IGoogleApiService/ReplayRequestResponse")]
        Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.DistanceMatrixResponse> ReplayRequest(System.Guid requestId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGoogleApiService/ReplayRequest", ReplyAction="http://tempuri.org/IGoogleApiService/ReplayRequestResponse")]
        System.Threading.Tasks.Task<Travel.Api.Core.Framework.ServiceResponse<Travel.Api.Domain.Models.DistanceMatrixResponse>> ReplayRequestAsync(System.Guid requestId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGoogleApiServiceChannel : Travel.Api.ConsoleApplication.GoogleApiService.IGoogleApiService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GoogleApiServiceClient : System.ServiceModel.ClientBase<Travel.Api.ConsoleApplication.GoogleApiService.IGoogleApiService>, Travel.Api.ConsoleApplication.GoogleApiService.IGoogleApiService {
        
        public GoogleApiServiceClient() {
        }
        
        public GoogleApiServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GoogleApiServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GoogleApiServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GoogleApiServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
