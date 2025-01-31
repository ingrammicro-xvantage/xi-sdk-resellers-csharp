/*
 * XI Sdk Resellers
 *
 * For Resellers seeking to innovate with Ingram Micro's API solutions, automate your eCommerce experience with our array of API's and webhooks to craft a seamless journey for your customers.
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
    ///  Class for testing InvoicesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InvoicesApiTests : IDisposable
    {
        private InvoicesApi instance;

        public InvoicesApiTests()
        {
            instance = new InvoicesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InvoicesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' InvoicesApi
            //Assert.IsType<InvoicesApi>(instance);
        }

        /// <summary>
        /// Test GetInvoicedetailsV61
        /// </summary>
        [Fact]
        public void GetInvoicedetailsV61Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string invoiceNumber = null;
            //string iMCustomerNumber = null;
            //string iMCountryCode = null;
            //string iMCorrelationID = null;
            //string iMApplicationID = null;
            //string? customerType = null;
            //bool? includeSerialNumbers = null;
            //var response = instance.GetInvoicedetailsV61(invoiceNumber, iMCustomerNumber, iMCountryCode, iMCorrelationID, iMApplicationID, customerType, includeSerialNumbers);
            //Assert.IsType<InvoiceDetailsv61Response>(response);
        }

        /// <summary>
        /// Test GetResellersV6Invoicesearch
        /// </summary>
        [Fact]
        public void GetResellersV6InvoicesearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string iMApplicationID = null;
            //string iMCustomerNumber = null;
            //string iMCountryCode = null;
            //string iMCorrelationID = null;
            //string? paymentTermsNetDate = null;
            //string? invoiceDate = null;
            //string? invoiceDueDate = null;
            //string? orderDate = null;
            //string? orderFromDate = null;
            //string? orderToDate = null;
            //string? orderNumber = null;
            //string? deliveryNumber = null;
            //string? invoiceNumber = null;
            //string? invoiceStatus = null;
            //string? invoiceType = null;
            //string? customerOrderNumber = null;
            //string? endCustomerOrderNumber = null;
            //string? specialBidNumber = null;
            //string? invoiceFromDueDate = null;
            //string? invoiceToDueDate = null;
            //List<string>? invoiceFromDate = null;
            //List<string>? invoiceToDate = null;
            //int? pageSize = null;
            //int? pageNumber = null;
            //string? orderby = null;
            //string? direction = null;
            //string? serialNumber = null;
            //var response = instance.GetResellersV6Invoicesearch(iMApplicationID, iMCustomerNumber, iMCountryCode, iMCorrelationID, paymentTermsNetDate, invoiceDate, invoiceDueDate, orderDate, orderFromDate, orderToDate, orderNumber, deliveryNumber, invoiceNumber, invoiceStatus, invoiceType, customerOrderNumber, endCustomerOrderNumber, specialBidNumber, invoiceFromDueDate, invoiceToDueDate, invoiceFromDate, invoiceToDate, pageSize, pageNumber, orderby, direction, serialNumber);
            //Assert.IsType<InvoiceSearchResponse>(response);
        }
    }
}
