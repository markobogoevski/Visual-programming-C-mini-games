using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Razor.TagHelpers;
using NUnit.Framework;
using SportsStore.Infrastructure;
using SportsStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Telerik.JustMock;
using Telerik.JustMock.Helpers;

namespace SportsStore.Tests
{
    class PageLinkTagHelpersTests
    {
        [Test]
        public void Process_With3Pages_GeneratesPageLinksCorrectly()
        {
            //Arrange
            var urlHelper = Mock.Create<IUrlHelper>();
            Mock.Arrange(()=> urlHelper.Action(Arg.IsAny<UrlActionContext>()))
                .Returns("Test/Page1")
                .Returns("Test/Page2")
                .Returns("Test/Page3");

            var urlHelperFactory = Mock.Create<IUrlHelperFactory>();
            Mock.Arrange(() => urlHelperFactory.GetUrlHelper(Arg.IsAny<ActionContext>()))
                .Returns(urlHelper) ;

            var pageLinkHelper = new PageLinkTagHelper(urlHelperFactory)
            {
                PageModel = new PagingInfo
                {
                    CurrentPage = 2,
                    TotalItems = 28,
                    ItemsPerPage = 10
                },
                PageAction = "Test"
            };

            TagHelperContext ctx = new TagHelperContext(
                new TagHelperAttributeList(),
                new Dictionary<object, object>(), "");

            var content = Mock.Create<TagHelperContent>();
            TagHelperOutput output = new TagHelperOutput("div", new TagHelperAttributeList(),
                (cache, encoder) => Task.FromResult(content));

            //Act
            pageLinkHelper.Process(ctx, output);

            //Assert
            output.Content.GetContent().Should().BeEquivalentTo((@"<a href=""Test/Page1"">1</a>"
                                + @"<a href=""Test/Page2"">2</a>"
                                + @"<a href=""Test/Page3"">3</a>"));
        }
    }
}
