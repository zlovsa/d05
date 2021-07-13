using System;
using Xunit;
using Markdown.Generator.Core.Markdown.Elements;
using System.Linq;
using Moq;
using Markdown.Generator.Core.Markdown;

namespace Markdown.Generator.Core.Tests
{
	public class GithubWikiDocumentBuilderTests
	{
		[Fact]
		public void Given_Load_When_Load_Then_RunsGenerateOnce() {
			//Arrange
			var mock = new Mock<IMarkdownGenerator>();
			mock.Setup(p => p.Load(new Type[] { typeof(Code) })).Returns(new MarkdownableType[] { new MarkdownableType(typeof(Code), null) });

			//Act
			IMarkdownGenerator markdownGenerator = mock.Object;
			var actual = markdownGenerator.Load(new Type[] { typeof(Code) });

			//Assert
			mock.Verify(p => p.Load(new Type[] { typeof(Code) }), Times.Once());
		}
	}
}
