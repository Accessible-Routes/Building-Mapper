using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMapper.Controls
{
    public class RoomEditorPanel : Panel
    {
        // The image to dispay, set in the Image property
        [AllowNull] private Image _image;
        // The current zoom factor
        private float _zoom = 1;
        // The zoom rectangle on the panel.
        private Rectangle _panelZoomRect;
        // _panelZoomRect on the actual image
        private Rectangle? _imageZoomRect;
        // Used in the mouse event handlers
        private bool _mouseDown;
        // The pen used to draw the zoom rectangle
        [AllowNull] private Pen _zoomPen;

        /// <summary>
        /// Create a new <see cref="PictureZoomPanel"/>
        /// </summary>
        public RoomEditorPanel()
        {
            // To prevent flickering
            DoubleBuffered = true;
            // To make resizing smoother
            ResizeRedraw = true;
            // Set default zoom pen
            ZoomPen = null;

            ZoomToFit();
        }

        public void Initialize()
        {
            ZoomToFit();
        }
        /// <summary>
        /// The image to be displayed
        /// </summary>
        [Category("Appearance"),
         Description("The image to be displayed.")]
        public Image Image
        {
            get { return _image; }
            set
            {
                _image = value;

                ZoomToFit();
            }
        }

        /// <summary>
        /// The pen used to draw the zoom rectangle.
        /// </summary>
        [Category("Appearance"),
         Description("The pen used to draw the zoom rectangle.")]
        public Pen? ZoomPen
        {
            get { return _zoomPen; }
            set
            {
                _zoomPen = value ?? new Pen(Color.Green, 2);
            }
        }

        /// <summary>
        /// Sets the zoom to a value where the whole image is visible.
        /// </summary>
        public void ZoomToFit()
        {
            _imageZoomRect = null;
            _mouseDown = false;
            _zoom = 1;

            // If no image is present, there is nothing further to do
            if (_image == null)
                return;

            var widthZoom = (float)Width / _image.Width;
            var heightZoom = (float)Height / _image.Height;
            // Make sure the whole image is visible
            _zoom = widthZoom < heightZoom ? widthZoom : heightZoom;

            // Force redraw
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (_image == null)
                return;

            _mouseDown = true;
            _panelZoomRect = new Rectangle(e.X, e.Y, 0, 0);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (_image == null || !_mouseDown)
                return;

            _mouseDown = false;

            // Without this, doubling clicking the control would cause zoom
            if (_panelZoomRect.Height == 0 || _panelZoomRect.Width == 0)
                return;

            // Tell the paint method to zoom
            _imageZoomRect = CalculateImageZoomRectangle();
            _zoom = RecalculateZoom();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (_image == null)
                return;

            // This makes sure that the left mouse button is pressed.
            if (e.Button == MouseButtons.Left)
            {
                // Draws the rectangle as the mouse moves
                _panelZoomRect = new Rectangle(
                    _panelZoomRect.Left,
                    _panelZoomRect.Top,
                    e.X - _panelZoomRect.Left,
                    e.Y - _panelZoomRect.Top);
            }

            // Force redraw to make sure the zoomRegion is painted
            Invalidate();
        }

        private Rectangle CalculateImageZoomRectangle()
        {
            // Calculate all the coordinates to required to transform
            var topLeft = new Point(_panelZoomRect.X,
                _panelZoomRect.Y);
            var topRight = new Point(_panelZoomRect.X + _panelZoomRect.Width,
                _panelZoomRect.Y);
            var bottomLeft = new Point(_panelZoomRect.X,
                _panelZoomRect.Y - _panelZoomRect.Height);
            var bottomRight = new Point(_panelZoomRect.X + _panelZoomRect.Height,
                _panelZoomRect.Y - _panelZoomRect.Height);

            var points = new[] { topLeft, topRight, bottomLeft, bottomRight };

            // Converts the points from panel to image position
            var mx = new Matrix(_zoom, 0, 0, _zoom, 0, 0);
            mx.Invert();
            mx.TransformPoints(points);

            var rectangleWidth = points[1].X - points[0].X;
            var rectangleHeight = points[0].Y - points[2].Y;

            // _imageZoom != null, means that we are zooming in on an
            // already zoomed in image. We must add the original values
            // to zoom in deeper
            return _imageZoomRect == null
                ? new Rectangle(points[0].X,
                    points[0].Y,
                    rectangleWidth,
                    rectangleHeight)
                : new Rectangle(points[0].X + _imageZoomRect.Value.X,
                    points[0].Y + _imageZoomRect.Value.Y,
                    rectangleWidth,
                    rectangleHeight);
        }

        private float RecalculateZoom()
        {
            if (!_imageZoomRect.HasValue)
                return _zoom;

            var widthZoom = (float)Width / _imageZoomRect.Value.Width;
            var heightZoom = (float)Height / _imageZoomRect.Value.Height;

            return widthZoom < heightZoom ? widthZoom : heightZoom;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (_image == null)
            {
                OnPaintBackground(e);
                return;
            }

            e.Graphics.Transform = new Matrix(_zoom, 0, 0, _zoom, 0, 0);

            // Turn of interpolation when zoomed
            e.Graphics.InterpolationMode = _imageZoomRect != null
                ? InterpolationMode.HighQualityBicubic
                : InterpolationMode.Default;

            DrawImage(e);

            if (_mouseDown)
                DrawZoomRectangle(e);

            base.OnPaint(e);
        }

        private void DrawImage(PaintEventArgs e)
        {
            var destRec = !_imageZoomRect.HasValue
                ? new Rectangle(0, 0, _image.Width, _image.Height)
                : new Rectangle(0, 0, _imageZoomRect.Value.Width,
                    _imageZoomRect.Value.Height);

            var sourceRec = !_imageZoomRect.HasValue
                ? new Rectangle(0, 0, _image.Width, _image.Height)
                : _imageZoomRect.Value;

            e.Graphics.DrawImage(_image, destRec,
                sourceRec.Location.X, sourceRec.Location.Y,
                sourceRec.Width, sourceRec.Height,
                GraphicsUnit.Pixel);
        }

        private void DrawZoomRectangle(PaintEventArgs e)
        {
            e.Graphics.Transform = new Matrix();
            e.Graphics.DrawRectangle(_zoomPen, _panelZoomRect);
        }
    }
}
