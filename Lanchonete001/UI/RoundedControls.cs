using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Lanchonete001.UI
{
    /// <summary>
    /// Paleta central de cores do sistema. Mantém exatamente as cores originais
    /// já usadas na tela de Estoque, apenas nomeando-as para reuso consistente.
    /// </summary>
    public static class AppColors
    {
        public static readonly Color Background = Color.FromArgb(232, 221, 203); // bege de fundo
        public static readonly Color CardBackground = Color.White;
        public static readonly Color AccentTan = Color.FromArgb(205, 179, 128); // dourado/tan original
        public static readonly Color AccentTanTint = Color.FromArgb(238, 228, 209);

        public static readonly Color Primary = Color.FromArgb(3, 101, 100);   // teal do botão original
        public static readonly Color PrimaryTint = Color.FromArgb(214, 231, 230);

        public static readonly Color HeaderDark = Color.FromArgb(3, 54, 73);     // cabeçalho do grid original
        public static readonly Color TextDark = Color.FromArgb(3, 22, 52);     // texto escuro original
        public static readonly Color TextMuted = Color.FromArgb(108, 108, 122);

        public static readonly Color Danger = Color.FromArgb(196, 69, 54);
        public static readonly Color DangerLight = Color.FromArgb(245, 213, 208); // vermelho claro original

        public static readonly Color Success = Color.FromArgb(46, 139, 87);
        public static readonly Color SuccessLight = Color.FromArgb(217, 240, 224);

        public static readonly Color Border = Color.FromArgb(224, 212, 191);
    }

    /// <summary>
    /// Painel com cantos arredondados, usado para cards, caixas de busca e badges.
    /// Pinta o fundo do "Parent" antes de desenhar o retângulo arredondado, para
    /// simular transparência nos cantos sem depender de Region (evita bugs de recorte
    /// de filhos).
    /// </summary>
    public class RoundedPanel : Panel
    {
        private int _cornerRadius = 16;
        private Color _borderColor = Color.Transparent;
        private int _borderThickness = 0;

        public int CornerRadius
        {
            get => _cornerRadius;
            set { _cornerRadius = value; Invalidate(); }
        }

        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        public int BorderThickness
        {
            get => _borderThickness;
            set { _borderThickness = value; Invalidate(); }
        }

        public RoundedPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint
                     | ControlStyles.UserPaint
                     | ControlStyles.OptimizedDoubleBuffer
                     | ControlStyles.ResizeRedraw, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Color parentColor = Parent != null ? Parent.BackColor : SystemColors.Control;
            e.Graphics.Clear(parentColor);

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);
            if (rect.Width <= 0 || rect.Height <= 0) return;

            using (GraphicsPath path = GetRoundedPath(rect, _cornerRadius))
            using (var brush = new SolidBrush(BackColor))
            {
                e.Graphics.FillPath(brush, path);

                if (_borderThickness > 0 && _borderColor != Color.Transparent)
                {
                    using (var pen = new Pen(_borderColor, _borderThickness))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            }

            base.OnPaint(e);
        }

        public static GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            int diameter = Math.Max(0, radius * 2);
            diameter = Math.Min(diameter, Math.Min(rect.Width, rect.Height));

            if (diameter <= 0)
            {
                path.AddRectangle(rect);
                return path;
            }

            var arc = new Rectangle(rect.X, rect.Y, diameter, diameter);

            path.StartFigure();
            path.AddArc(arc, 180, 90);

            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);

            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            arc.X = rect.X;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }

    /// <summary>
    /// Botão com cantos arredondados e efeito de hover/pressed, sem depender de
    /// bibliotecas externas.
    /// </summary>
    public class RoundedButton : Button
    {
        private int _cornerRadius = 10;
        private bool _isHovering;
        private bool _isPressed;
        private Color _normalColor;
        private Color _hoverColor;
        private Color _pressedColor;

        public int CornerRadius
        {
            get => _cornerRadius;
            set { _cornerRadius = value; Invalidate(); }
        }

        public RoundedButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint
                     | ControlStyles.UserPaint
                     | ControlStyles.OptimizedDoubleBuffer
                     | ControlStyles.ResizeRedraw, true);

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Cursor = Cursors.Hand;

            MouseEnter += (s, e) => { _isHovering = true; Invalidate(); };
            MouseLeave += (s, e) => { _isHovering = false; _isPressed = false; Invalidate(); };
            MouseDown += (s, e) => { _isPressed = true; Invalidate(); };
            MouseUp += (s, e) => { _isPressed = false; Invalidate(); };

            RecalculateColors();
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            RecalculateColors();
        }

        private void RecalculateColors()
        {
            _normalColor = BackColor;
            _hoverColor = Lighten(BackColor, 0.12f);
            _pressedColor = Darken(BackColor, 0.12f);
            Invalidate();
        }

        private static Color Lighten(Color c, float factor)
        {
            int r = c.R + (int)((255 - c.R) * factor);
            int g = c.G + (int)((255 - c.G) * factor);
            int b = c.B + (int)((255 - c.B) * factor);
            return Color.FromArgb(c.A, Clamp(r), Clamp(g), Clamp(b));
        }

        private static Color Darken(Color c, float factor)
        {
            int r = (int)(c.R * (1 - factor));
            int g = (int)(c.G * (1 - factor));
            int b = (int)(c.B * (1 - factor));
            return Color.FromArgb(c.A, Clamp(r), Clamp(g), Clamp(b));
        }

        private static int Clamp(int v) => Math.Max(0, Math.Min(255, v));

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Color parentColor = Parent != null ? Parent.BackColor : SystemColors.Control;
            e.Graphics.Clear(parentColor);

            Color fill = _isPressed ? _pressedColor : (_isHovering ? _hoverColor : _normalColor);

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);
            if (rect.Width <= 0 || rect.Height <= 0) return;

            using (GraphicsPath path = RoundedPanel.GetRoundedPath(rect, _cornerRadius))
            using (var brush = new SolidBrush(fill))
            {
                e.Graphics.FillPath(brush, path);
            }

            TextRenderer.DrawText(
                e.Graphics,
                Text,
                Font,
                rect,
                ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
        }
    }
}