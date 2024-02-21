/*
 * XI Sdk Resellers
 *
 * For Resellers. Who are looking to Innovate with Ingram Micro's API SolutionsAutomate your eCommerce with our offering of APIs and Webhooks to create a seamless experience for your customers.
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using xi.sdk.resellers.Client;
using xi.sdk.resellers.Api;
// uncomment below to import models
//using xi.sdk.resellers.Model;

namespace xi.sdk.resellers.Test.Api
{
    /// <summary>
    ///  Class for testing RenewalsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RenewalsApiTests : IDisposable
    {
        private RenewalsApi instance;

        public RenewalsApiTests()
        {
            instance = new RenewalsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RenewalsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' RenewalsApi
            //Assert.IsType<RenewalsApi>(instance);
        }

        /// <summary>
        /// Test GetResellersV6Renewalsdetails
        /// </summary>
        [Fact]
        public void GetResellersV6RenewalsdetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string iMCustomerNumber = null;
            //string iMCountryCode = null;
            //string iMCorrelationID = null;
            //string renewalId = null;
            //string? iMSenderID = null;
            //var response = instance.GetResellersV6Renewalsdetails(iMCustomerNumber, iMCountryCode, iMCorrelationID, renewalId, iMSenderID);
            //Assert.IsType<RenewalsDetailsResponse>(response);
        }

        /// <summary>
        /// Test PostRenewalssearch
        /// </summary>
        [Fact]
        public void PostRenewalssearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string iMCustomerNumber = null;
            //string iMCountryCode = null;
            //string iMCorrelationID = null;
            //string? iMSenderID = null;
            //string? customerOrderNumber = null;
            //string? ingramPurchaseOrderNumber = null;
            //string? serialNumber = null;
            //string? page = null;
            //string? size = null;
            //string? sort = null;
            //RenewalsSearchRequest? renewalsSearchRequest = null;
            //var response = instance.PostRenewalssearch(iMCustomerNumber, iMCountryCode, iMCorrelationID, iMSenderID, customerOrderNumber, ingramPurchaseOrderNumber, serialNumber, page, size, sort, renewalsSearchRequest);
            //Assert.IsType<RenewalsSearchResponse>(response);
        }
    }
}
