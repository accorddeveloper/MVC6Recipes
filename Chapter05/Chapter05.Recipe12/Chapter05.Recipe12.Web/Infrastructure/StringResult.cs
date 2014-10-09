using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Framework.DependencyInjection;
using Microsoft.AspNet.Mvc.Core;
using System.Text;

namespace Chapter05.Recipe12.Web.Infrastructure
{
    /// <summary>
    /// Summary description for StringResult
    /// </summary>
    public class StringResult : ViewResult
    {
	    public StringResult(string viewName, object model, ViewDataDictionary viewData)
	    {
            if (model != null && viewData!=null)
            {
                ViewData = viewData;
                ViewData.Model = model;
            }
            ViewName = viewName;

	    }
        private const int BufferSize = 1024;
        private MemoryStream m_MemStream = new MemoryStream();
        StreamWrapper wrappedStream = null;
        public override async Task ExecuteResultAsync( ActionContext context)
        {
            var viewEngine = ViewEngine ?? context.HttpContext.RequestServices.GetService<ICompositeViewEngine>();

            var viewName = ViewName ?? context.ActionDescriptor.Name;
            var view = FindView(viewEngine, context, viewName);

            using (view as IDisposable)
            {
                context.HttpContext.Response.ContentType = "text/html; charset=utf-8";
                var encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);
                wrappedStream = new StreamWrapper(m_MemStream);
                using (var writer = new StreamWriter(wrappedStream, encoding, BufferSize, leaveOpen: true))
                {
                    try
                    {
                        var viewContext = new ViewContext(context, view, ViewData, writer);
                        await view.RenderAsync(viewContext);
                        
                    }
                    catch
                    {
                        
                        throw;
                    }
                }
            }
        }

        public override string ToString()
        {
            if (m_MemStream != null)
            {
                m_MemStream.Position = 0;
                StreamReader reader = new StreamReader(m_MemStream);
                string text = reader.ReadToEnd();
                return text;
            }
            return "No Content Found";
        }
        private static IView FindView(IViewEngine viewEngine, ActionContext context, string viewName)
        {
            var result = viewEngine.FindView(context, viewName);
            if (!result.Success)
            {
                var locations = string.Empty;
                if (result.SearchedLocations != null)
                {
                    locations = Environment.NewLine +
                        string.Join(Environment.NewLine, result.SearchedLocations);
                }

            }

            return result.View;
        }

        private class StreamWrapper : Stream
        {
            private readonly Stream _wrappedStream;

            public StreamWrapper(Stream stream)
            {
                _wrappedStream = stream;
            }

            public bool BlockWrites { get; set; }

            public override bool CanRead
            {
                get { return _wrappedStream.CanRead; }
            }

            public override bool CanSeek
            {
                get { return _wrappedStream.CanSeek; }
            }

            public override bool CanWrite
            {
                get { return _wrappedStream.CanWrite; }
            }

            public override void Flush()
            {
                if (!BlockWrites)
                {
                    _wrappedStream.Flush();
                }
            }

            public override long Length
            {
                get { return _wrappedStream.Length; }
            }

            public override long Position
            {
                get
                {
                    return _wrappedStream.Position;
                }
                set
                {
                    _wrappedStream.Position = value;
                }
            }

            public override int Read(byte[] buffer, int offset, int count)
            {
                return _wrappedStream.Read(buffer, offset, count);
            }

            public override long Seek(long offset, SeekOrigin origin)
            {
                return Seek(offset, origin);
            }

            public override void SetLength(long value)
            {
                SetLength(value);
            }

            public override void Write(byte[] buffer, int offset, int count)
            {
                if (!BlockWrites)
                {
                    _wrappedStream.Write(buffer, offset, count);
                }
            }
        }


    }
}