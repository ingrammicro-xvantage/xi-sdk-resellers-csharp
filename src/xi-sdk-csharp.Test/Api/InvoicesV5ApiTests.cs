/*
 * Reseller API Documentation - United States
 *
 * For Resellers. <br> Who are looking to Innovate with Ingram Micro's API SolutionsAutomate your eCommerce with our offering of APIs and Webhooks to create a seamless experience for your customers.
 *
 * The version of the OpenAPI document: 6.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using xi-sdk-csharp.Client;
using xi-sdk-csharp.Api;
// uncomment below to import models
//using xi-sdk-csharp.Model;

namespace xi-sdk-csharp.Test.Api
{
    /// <summary>
    ///  Class for testing InvoicesV5Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InvoicesV5ApiTests : IDisposable
    {
        private InvoicesV5Api instance;

        public InvoicesV5ApiTests()
        {
            instance = new InvoicesV5Api();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InvoicesV5Api
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' InvoicesV5Api
            //Assert.IsType<InvoicesV5Api>(instance);
        }

        /// <summary>
        /// Test GetInvoices
        /// </summary>
        [Fact]
        public void GetInvoicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string invoiceNumber = null;
            //string customerNumber = null;
            //string isoCountryCode = null;
            //var response = instance.GetInvoices(invoiceNumber, customerNumber, isoCountryCode);
            //Assert.IsType<InvoiceDetails>(response);
        }
    }
}
