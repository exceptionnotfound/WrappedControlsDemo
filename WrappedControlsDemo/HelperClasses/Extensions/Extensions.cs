using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace WrappedControlsDemo.HelperClasses.Extensions
{
    public static class Extensions
    {
        #region Text Box
        public static MvcHtmlString WrappedTextBoxFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression)
        {
            return WrappedTextBoxFor<TModel, TValue>(html, expression, null);
        }

        public static MvcHtmlString WrappedTextBoxFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, object htmlAttributes)
        {
            return WrappedTextBoxFor<TModel, TValue>(html, expression, HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
        }

        public static MvcHtmlString WrappedTextBoxFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, IDictionary<string, object> htmlAttributes)
        {
            ModelMetadata metadata = ModelMetadata.FromLambdaExpression(expression, html.ViewData);
            string fieldName = ExpressionHelper.GetExpressionText(expression);
            string labelText = metadata.DisplayName ?? metadata.PropertyName ?? fieldName.Split('.').Last();

            TagBuilder builder = new TagBuilder("label");
            builder.InnerHtml = labelText + html.TextBoxFor(expression, htmlAttributes).ToString();
            return MvcHtmlString.Create(builder.ToString());
        }

        #endregion
    }
}