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
    ///  Class for testing ProductCatalogV5Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProductCatalogV5ApiTests : IDisposable
    {
        private ProductCatalogV5Api instance;

        public ProductCatalogV5ApiTests()
        {
            instance = new ProductCatalogV5Api();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProductCatalogV5Api
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ProductCatalogV5Api
            //Assert.IsType<ProductCatalogV5Api>(instance);
        }

        /// <summary>
        /// Test GetV5CatalogProductsearch
        /// </summary>
        [Fact]
        public void GetV5CatalogProductsearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customerNumber = null;
            //string isoCountryCode = null;
            //string partNumber = null;
            //var response = instance.GetV5CatalogProductsearch(customerNumber, isoCountryCode, partNumber);
            //Assert.IsType<ProductSearchResponse>(response);
        }

        /// <summary>
        /// Test MultiSKUPriceAndStock
        /// </summary>
        [Fact]
        public void MultiSKUPriceAndStockTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PriceAndAvailabilityRequest? priceAndAvailabilityRequest = null;
            //var response = instance.MultiSKUPriceAndStock(priceAndAvailabilityRequest);
            //Assert.IsType<PriceAndAvailabilityResponse>(response);
        }
    }
}
