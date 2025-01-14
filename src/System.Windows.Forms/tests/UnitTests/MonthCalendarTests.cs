﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using WinForms.Common.Tests;
using Xunit;

namespace System.Windows.Forms.Tests
{
    public class MonthCalendarTests
    {
        [WinFormsFact]
        public void MonthCalendar_Ctor_Default()
        {
            using var control = new SubMonthCalendar();
            Assert.False(control.AllowDrop);
            Assert.Equal(AnchorStyles.Top | AnchorStyles.Left, control.Anchor);
            Assert.Empty(control.AnnuallyBoldedDates);
            Assert.NotSame(control.AnnuallyBoldedDates, control.AnnuallyBoldedDates);
            Assert.False(control.AutoSize);
            Assert.Equal(SystemColors.Window, control.BackColor);
            Assert.Null(control.BackgroundImage);
            Assert.Equal(ImageLayout.Tile, control.BackgroundImageLayout);
            Assert.Null(control.BindingContext);
            Assert.Empty(control.BoldedDates);
            Assert.NotSame(control.BoldedDates, control.BoldedDates);
            Assert.True(control.Bottom > 0);
            Assert.Equal(0, control.Bounds.X);
            Assert.Equal(0, control.Bounds.Y);
            Assert.True(control.Bounds.Width > 0);
            Assert.True(control.Bounds.Height > 0);
            Assert.Equal(new Size(1, 1), control.CalendarDimensions);
            Assert.False(control.CanEnableIme);
            Assert.True(control.CanRaiseEvents);
            Assert.True(control.CausesValidation);
            Assert.True(control.ClientSize.Width > 0);
            Assert.True(control.ClientSize.Height > 0);
            Assert.Equal(0, control.ClientRectangle.X);
            Assert.Equal(0, control.ClientRectangle.Y);
            Assert.True(control.ClientRectangle.Width > 0);
            Assert.True(control.ClientRectangle.Height > 0);
            Assert.Null(control.Container);
            Assert.Null(control.ContextMenu);
            Assert.Null(control.ContextMenuStrip);
            Assert.Empty(control.Controls);
            Assert.Same(control.Controls, control.Controls);
            Assert.False(control.Created);
            Assert.Same(Cursors.Default, control.Cursor);
            Assert.Same(Cursors.Default, control.DefaultCursor);
            Assert.Equal(ImeMode.Disable, control.DefaultImeMode);
            Assert.Equal(new Padding(9), control.DefaultMargin);
            Assert.Equal(Size.Empty, control.DefaultMaximumSize);
            Assert.Equal(Size.Empty, control.DefaultMinimumSize);
            Assert.Equal(Padding.Empty, control.DefaultPadding);
            Assert.True(control.DefaultSize.Width > 0);
            Assert.True(control.DefaultSize.Height > 0);
            Assert.False(control.DesignMode);
            Assert.Equal(0, control.DisplayRectangle.X);
            Assert.Equal(0, control.DisplayRectangle.Y);
            Assert.True(control.DisplayRectangle.Width > 0);
            Assert.True(control.DisplayRectangle.Height > 0);
            Assert.Equal(DockStyle.None, control.Dock);
            Assert.False(control.DoubleBuffered);
            Assert.True(control.Enabled);
            Assert.NotNull(control.Events);
            Assert.Same(control.Events, control.Events);
            Assert.Equal(Day.Default, control.FirstDayOfWeek);
            Assert.Equal(Control.DefaultFont, control.Font);
            Assert.Equal(control.Font.Height, control.FontHeight);
            Assert.Equal(SystemColors.WindowText, control.ForeColor);
            Assert.False(control.HasChildren);
            Assert.True(control.Height > 0);
            Assert.Equal(ImeMode.Disable, control.ImeMode);
            Assert.Equal(ImeMode.Disable, control.ImeModeBase);
            Assert.Equal(0, control.Left);
            Assert.Equal(Point.Empty, control.Location);
            Assert.Equal(new Padding(9), control.Margin);
            Assert.Equal(new DateTime(9998, 12, 31), control.MaxDate);
            Assert.Equal(Size.Empty, control.MaximumSize);
            Assert.Equal(7, control.MaxSelectionCount);
            Assert.Equal(new DateTime(1753, 1, 1), control.MinDate);
            Assert.Equal(Size.Empty, control.MinimumSize);
            Assert.Empty(control.MonthlyBoldedDates);
            Assert.NotSame(control.MonthlyBoldedDates, control.MonthlyBoldedDates);
            Assert.Equal(Padding.Empty, control.Padding);
            Assert.Null(control.Parent);
            Assert.True(control.PreferredSize.Width > 0);
            Assert.True(control.PreferredSize.Height > 0);
            Assert.Equal("Microsoft\u00AE .NET", control.ProductName);
            Assert.False(control.RecreatingHandle);
            Assert.Null(control.Region);
            Assert.False(control.ResizeRedraw);
            Assert.True(control.Right > 0);
            Assert.Equal(RightToLeft.No, control.RightToLeft);
            Assert.False(control.RightToLeftLayout);
            Assert.Equal(0, control.ScrollChange);
            Assert.Equal(DateTime.Now.Date, control.SelectionEnd);
            Assert.Equal(DateTime.Now.Date, control.SelectionRange.Start);
            Assert.Equal(DateTime.Now.Date, control.SelectionRange.End);
            Assert.NotSame(control.SelectionRange, control.SelectionRange);
            Assert.Equal(DateTime.Now.Date, control.SelectionStart);
            Assert.True(control.ShowToday);
            Assert.True(control.ShowTodayCircle);
            Assert.False(control.ShowWeekNumbers);
            Assert.Equal(new Size(176, 153), control.SingleMonthSize);
            Assert.Null(control.Site);
            Assert.True(control.Size.Width > 0);
            Assert.True(control.Size.Height > 0);
            Assert.Equal(0, control.TabIndex);
            Assert.True(control.TabStop);
            Assert.Empty(control.Text);
            Assert.Equal(SystemColors.ActiveCaption, control.TitleBackColor);
            Assert.Equal(SystemColors.ActiveCaptionText, control.TitleForeColor);
            Assert.Equal(DateTime.Now.Date, control.TodayDate);
            Assert.False(control.TodayDateSet);
            Assert.Equal(0, control.Top);
            Assert.Equal(SystemColors.GrayText, control.TrailingForeColor);
            Assert.True(control.Visible);
            Assert.True(control.Width > 0);

            Assert.False(control.IsHandleCreated);
        }

        [WinFormsFact]
        public void MonthCalendar_CreateParams_GetDefault_ReturnsExpected()
        {
            using var control = new SubMonthCalendar();
            CreateParams createParams = control.CreateParams;
            Assert.Null(createParams.Caption);
            Assert.Equal("SysMonthCal32", createParams.ClassName);
            Assert.Equal(0x8, createParams.ClassStyle);
            Assert.Equal(0, createParams.ExStyle);
            Assert.Equal(control.Height, createParams.Height);
            Assert.Equal(IntPtr.Zero, createParams.Parent);
            Assert.Null(createParams.Param);
            Assert.Equal(0x56010003, createParams.Style);
            Assert.Equal(control.Width, createParams.Width);
            Assert.Equal(0, createParams.X);
            Assert.Equal(0, createParams.Y);
            Assert.Same(createParams, control.CreateParams);
            Assert.False(control.IsHandleCreated);
        }

        public static IEnumerable<object[]> AnnuallyBoldedDates_Set_TestData()
        {
            yield return new object[] { null, new DateTime[0] };
            yield return new object[] { new DateTime[0], new DateTime[0] };

            yield return new object[] { new DateTime[] { new DateTime(2019, 01, 1), new DateTime(2019, 01, 20) }, new DateTime[] { new DateTime(2019, 01, 1), new DateTime(2019, 01, 20) } };
            yield return new object[] { new DateTime[] { new DateTime(2017, 01, 1), new DateTime(2018, 01, 20) }, new DateTime[] { new DateTime(2017, 01, 1), new DateTime(2018, 01, 20) } };
            yield return new object[] { new DateTime[] { new DateTime(2019, 01, 1), new DateTime(2019, 01, 1), new DateTime(2018, 01, 1) }, new DateTime[] { new DateTime(2019, 01, 1), new DateTime(2019, 01, 1), new DateTime(2018, 01, 1) } };
            yield return new object[] { new DateTime[] { DateTime.MinValue, DateTime.MaxValue }, new DateTime[] { DateTime.MinValue, DateTime.MaxValue } };

            var everyMonth = new DateTime[]
            {
                new DateTime(2019, 01, 1),
                new DateTime(2019, 02, 2),
                new DateTime(2019, 03, 3),
                new DateTime(2019, 04, 4),
                new DateTime(2019, 05, 5),
                new DateTime(2019, 06, 6),
                new DateTime(2019, 07, 7),
                new DateTime(2019, 08, 8),
                new DateTime(2019, 09, 9),
                new DateTime(2019, 10, 10),
                new DateTime(2019, 11, 11),
                new DateTime(2019, 12, 12),
            };
            yield return new object[] { everyMonth, everyMonth };
        }

        [Theory]
        [MemberData(nameof(AnnuallyBoldedDates_Set_TestData))]
        public void MonthCalendar_AnnuallyBoldedDates_Set_GetReturnsExpected(DateTime[] value, DateTime[] expected)
        {
            using var calendar = new MonthCalendar
            {
                AnnuallyBoldedDates = value
            };
            Assert.Equal(expected, calendar.AnnuallyBoldedDates);
            Assert.NotSame(value, calendar.AnnuallyBoldedDates);
            Assert.NotSame(calendar.AnnuallyBoldedDates, calendar.AnnuallyBoldedDates);
            Assert.False(calendar.IsHandleCreated);

            // Set same.
            calendar.AnnuallyBoldedDates = value;
            Assert.Equal(expected, calendar.AnnuallyBoldedDates);
            Assert.NotSame(value, calendar.AnnuallyBoldedDates);
            Assert.NotSame(calendar.AnnuallyBoldedDates, calendar.AnnuallyBoldedDates);
            Assert.False(calendar.IsHandleCreated);
        }

        [Theory]
        [MemberData(nameof(AnnuallyBoldedDates_Set_TestData))]
        public void MonthCalendar_AnnuallyBoldedDates_SetWithHandle_GetReturnsExpected(DateTime[] value, DateTime[] expected)
        {
            using var calendar = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, calendar.Handle);
            int invalidatedCallCount = 0;
            calendar.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            calendar.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            calendar.HandleCreated += (sender, e) => createdCallCount++;

            calendar.AnnuallyBoldedDates = value;
            Assert.Equal(expected, calendar.AnnuallyBoldedDates);
            Assert.NotSame(value, calendar.AnnuallyBoldedDates);
            Assert.NotSame(calendar.AnnuallyBoldedDates, calendar.AnnuallyBoldedDates);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(1, createdCallCount);

            // Set same.
            calendar.AnnuallyBoldedDates = value;
            Assert.Equal(expected, calendar.AnnuallyBoldedDates);
            Assert.NotSame(value, calendar.AnnuallyBoldedDates);
            Assert.NotSame(calendar.AnnuallyBoldedDates, calendar.AnnuallyBoldedDates);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(2, createdCallCount);
        }

        public static IEnumerable<object[]> BackColor_Set_TestData()
        {
            yield return new object[] { Color.Empty, SystemColors.Window };
            yield return new object[] { Color.Red, Color.Red };
        }

        [Theory]
        [MemberData(nameof(BackColor_Set_TestData))]
        public void MonthCalendar_BackColor_Set_GetReturnsExpected(Color value, Color expected)
        {
            using var control = new MonthCalendar
            {
                BackColor = value
            };
            Assert.Equal(expected, control.BackColor);
            Assert.False(control.IsHandleCreated);

            // Set same.
            control.BackColor = value;
            Assert.Equal(expected, control.BackColor);
            Assert.False(control.IsHandleCreated);
        }

        public static IEnumerable<object[]> BackColor_SetWithHandle_TestData()
        {
            yield return new object[] { Color.Empty, SystemColors.Window, 0 };
            yield return new object[] { Color.Red, Color.Red, 1 };
        }

        [Theory]
        [MemberData(nameof(BackColor_SetWithHandle_TestData))]
        public void MonthCalendar_BackColor_SetWithHandle_GetReturnsExpected(Color value, Color expected, int expectedInvalidatedCallCount)
        {
            using var control = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, control.Handle);
            int invalidatedCallCount = 0;
            control.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            control.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            control.HandleCreated += (sender, e) => createdCallCount++;

            control.BackColor = value;
            Assert.Equal(expected, control.BackColor);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(expectedInvalidatedCallCount, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Set same.
            control.BackColor = value;
            Assert.Equal(expected, control.BackColor);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(expectedInvalidatedCallCount, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Fact]
        public void MonthCalendar_BackColor_SetWithHandler_CallsBackColorChanged()
        {
            using var control = new MonthCalendar();
            int callCount = 0;
            EventHandler handler = (sender, e) =>
            {
                Assert.Same(control, sender);
                Assert.Same(EventArgs.Empty, e);
                callCount++;
            };
            control.BackColorChanged += handler;

            // Set different.
            control.BackColor = Color.Red;
            Assert.Equal(Color.Red, control.BackColor);
            Assert.Equal(1, callCount);

            // Set same.
            control.BackColor = Color.Red;
            Assert.Equal(Color.Red, control.BackColor);
            Assert.Equal(1, callCount);

            // Set different.
            control.BackColor = Color.Empty;
            Assert.Equal(SystemColors.Window, control.BackColor);
            Assert.Equal(2, callCount);

            // Remove handler.
            control.BackColorChanged -= handler;
            control.BackColor = Color.Red;
            Assert.Equal(Color.Red, control.BackColor);
            Assert.Equal(2, callCount);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetImageTheoryData))]
        public void MonthCalendar_BackgroundImage_Set_GetReturnsExpected(Image value)
        {
            using var control = new MonthCalendar
            {
                BackgroundImage = value
            };
            Assert.Equal(value, control.BackgroundImage);

            // Set same.
            control.BackgroundImage = value;
            Assert.Equal(value, control.BackgroundImage);
        }

        [Fact]
        public void MonthCalendar_BackgroundImage_SetWithHandler_CallsBackgroundImageChanged()
        {
            using var control = new MonthCalendar();
            int callCount = 0;
            EventHandler handler = (sender, e) =>
            {
                Assert.Same(control, sender);
                Assert.Same(EventArgs.Empty, e);
                callCount++;
            };
            control.BackgroundImageChanged += handler;

            // Set different.
            var image1 = new Bitmap(10, 10);
            control.BackgroundImage = image1;
            Assert.Same(image1, control.BackgroundImage);
            Assert.Equal(1, callCount);

            // Set same.
            control.BackgroundImage = image1;
            Assert.Same(image1, control.BackgroundImage);
            Assert.Equal(1, callCount);

            // Set different.
            var image2 = new Bitmap(10, 10);
            control.BackgroundImage = image2;
            Assert.Same(image2, control.BackgroundImage);
            Assert.Equal(2, callCount);

            // Set null.
            control.BackgroundImage = null;
            Assert.Null(control.BackgroundImage);
            Assert.Equal(3, callCount);

            // Remove handler.
            control.BackgroundImageChanged -= handler;
            control.BackgroundImage = image1;
            Assert.Same(image1, control.BackgroundImage);
            Assert.Equal(3, callCount);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetEnumTypeTheoryData), typeof(ImageLayout))]
        public void MonthCalendar_BackgroundImageLayout_Set_GetReturnsExpected(ImageLayout value)
        {
            using var control = new SubMonthCalendar
            {
                BackgroundImageLayout = value
            };
            Assert.Equal(value, control.BackgroundImageLayout);
            Assert.False(control.DoubleBuffered);
            Assert.False(control.IsHandleCreated);

            // Set same.
            control.BackgroundImageLayout = value;
            Assert.Equal(value, control.BackgroundImageLayout);
            Assert.False(control.DoubleBuffered);
            Assert.False(control.IsHandleCreated);
        }

        [Fact]
        public void MonthCalendar_BackgroundImageLayout_SetWithHandler_CallsBackgroundImageLayoutChanged()
        {
            using var control = new MonthCalendar();
            int callCount = 0;
            EventHandler handler = (sender, e) =>
            {
                Assert.Same(control, sender);
                Assert.Same(EventArgs.Empty, e);
                callCount++;
            };
            control.BackgroundImageLayoutChanged += handler;

            // Set different.
            control.BackgroundImageLayout = ImageLayout.Center;
            Assert.Equal(ImageLayout.Center, control.BackgroundImageLayout);
            Assert.Equal(1, callCount);

            // Set same.
            control.BackgroundImageLayout = ImageLayout.Center;
            Assert.Equal(ImageLayout.Center, control.BackgroundImageLayout);
            Assert.Equal(1, callCount);

            // Set different.
            control.BackgroundImageLayout = ImageLayout.Stretch;
            Assert.Equal(ImageLayout.Stretch, control.BackgroundImageLayout);
            Assert.Equal(2, callCount);

            // Remove handler.
            control.BackgroundImageLayoutChanged -= handler;
            control.BackgroundImageLayout = ImageLayout.Center;
            Assert.Equal(ImageLayout.Center, control.BackgroundImageLayout);
            Assert.Equal(2, callCount);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetEnumTypeTheoryDataInvalid), typeof(ImageLayout))]
        public void MonthCalendar_BackgroundImageLayout_SetInvalid_ThrowsInvalidEnumArgumentException(ImageLayout value)
        {
            using var control = new MonthCalendar();
            Assert.Throws<InvalidEnumArgumentException>("value", () => control.BackgroundImageLayout = value);
        }

        public static IEnumerable<object[]> BoldedDates_Set_TestData()
        {
            yield return new object[] { null, new DateTime[0] };
            yield return new object[] { new DateTime[0], new DateTime[0] };

            yield return new object[] { new DateTime[] { new DateTime(2019, 01, 1), new DateTime(2019, 01, 20) }, new DateTime[] { new DateTime(2019, 01, 1), new DateTime(2019, 01, 20) } };
            yield return new object[] { new DateTime[] { new DateTime(2017, 01, 1), new DateTime(2018, 01, 20) }, new DateTime[] { new DateTime(2017, 01, 1), new DateTime(2018, 01, 20) } };
            yield return new object[] { new DateTime[] { new DateTime(2019, 01, 1), new DateTime(2019, 01, 1), new DateTime(2018, 01, 1) }, new DateTime[] { new DateTime(2019, 01, 1), new DateTime(2019, 01, 1), new DateTime(2018, 01, 1) } };
            yield return new object[] { new DateTime[] { DateTime.MinValue, DateTime.MaxValue }, new DateTime[] { DateTime.MinValue, DateTime.MaxValue } };

            var everyMonth = new DateTime[]
            {
                new DateTime(2019, 01, 1),
                new DateTime(2019, 02, 2),
                new DateTime(2019, 03, 3),
                new DateTime(2019, 04, 4),
                new DateTime(2019, 05, 5),
                new DateTime(2019, 06, 6),
                new DateTime(2019, 07, 7),
                new DateTime(2019, 08, 8),
                new DateTime(2019, 09, 9),
                new DateTime(2019, 10, 10),
                new DateTime(2019, 11, 11),
                new DateTime(2019, 12, 12),
            };
            yield return new object[] { everyMonth, everyMonth };
        }

        [Theory]
        [MemberData(nameof(BoldedDates_Set_TestData))]
        public void MonthCalendar_BoldedDates_Set_GetReturnsExpected(DateTime[] value, DateTime[] expected)
        {
            using var calendar = new MonthCalendar
            {
                BoldedDates = value
            };
            Assert.Equal(expected, calendar.BoldedDates);
            Assert.NotSame(value, calendar.BoldedDates);
            Assert.NotSame(calendar.BoldedDates, calendar.BoldedDates);
            Assert.False(calendar.IsHandleCreated);

            // Set same.
            calendar.BoldedDates = value;
            Assert.Equal(expected, calendar.BoldedDates);
            Assert.NotSame(value, calendar.BoldedDates);
            Assert.NotSame(calendar.BoldedDates, calendar.BoldedDates);
            Assert.False(calendar.IsHandleCreated);
        }

        [Theory]
        [MemberData(nameof(BoldedDates_Set_TestData))]
        public void MonthCalendar_BoldedDates_SetWithHandle_GetReturnsExpected(DateTime[] value, DateTime[] expected)
        {
            using var calendar = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, calendar.Handle);
            int invalidatedCallCount = 0;
            calendar.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            calendar.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            calendar.HandleCreated += (sender, e) => createdCallCount++;

            calendar.BoldedDates = value;
            Assert.Equal(expected, calendar.BoldedDates);
            Assert.NotSame(value, calendar.BoldedDates);
            Assert.NotSame(calendar.BoldedDates, calendar.BoldedDates);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(1, createdCallCount);

            // Set same.
            calendar.BoldedDates = value;
            Assert.Equal(expected, calendar.BoldedDates);
            Assert.NotSame(value, calendar.BoldedDates);
            Assert.NotSame(calendar.BoldedDates, calendar.BoldedDates);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(2, createdCallCount);
        }

        public static IEnumerable<object[]> CalendarDimensions_Set_TestData()
        {
            yield return new object[] { new Size(1, 1), new Size(1, 1) };
            yield return new object[] { new Size(1, 2), new Size(1, 2) };
            yield return new object[] { new Size(2, 1), new Size(2, 1) };
            yield return new object[] { new Size(2, 3), new Size(2, 3) };
            yield return new object[] { new Size(3, 4), new Size(3, 4) };
            yield return new object[] { new Size(3, 5), new Size(3, 4) };
            yield return new object[] { new Size(3, 10), new Size(3, 4) };
            yield return new object[] { new Size(5, 3), new Size(4, 3) };
            yield return new object[] { new Size(10, 3), new Size(4, 3) };
        }

        [Theory]
        [MemberData(nameof(CalendarDimensions_Set_TestData))]
        public void MonthCalendar_CalendarDimensions_Set_GetReturnsExpected(Size value, Size expected)
        {
            using var calendar = new MonthCalendar
            {
                CalendarDimensions = value
            };
            Assert.Equal(expected, calendar.CalendarDimensions);
            Assert.False(calendar.IsHandleCreated);

            // Set same.
            calendar.CalendarDimensions = value;
            Assert.Equal(expected, calendar.CalendarDimensions);
            Assert.False(calendar.IsHandleCreated);
        }

        [Theory]
        [InlineData(1, 12)]
        [InlineData(12, 1)]
        public void MonthCalendar_CalendarDimensions_SetAreaOfTwelve_GetReturnsExpected(int width, int height)
        {
            var value = new Size(width, height);
            using var calendar = new MonthCalendar
            {
                CalendarDimensions = value
            };
            Assert.True(calendar.CalendarDimensions.Width > 0 && calendar.CalendarDimensions.Width < 12);
            Assert.True(calendar.CalendarDimensions.Height > 0 && calendar.CalendarDimensions.Height < 12);
            Assert.NotEqual(value, calendar.CalendarDimensions);
            Assert.False(calendar.IsHandleCreated);

            // Set same.
            calendar.CalendarDimensions = value;
            Assert.True(calendar.CalendarDimensions.Width > 0 && calendar.CalendarDimensions.Width < 12);
            Assert.True(calendar.CalendarDimensions.Height > 0 && calendar.CalendarDimensions.Height < 12);
            Assert.NotEqual(value, calendar.CalendarDimensions);
            Assert.False(calendar.IsHandleCreated);
        }

        [Theory]
        [MemberData(nameof(CalendarDimensions_Set_TestData))]
        public void MonthCalendar_CalendarDimensions_SetWithHandle_GetReturnsExpected(Size value, Size expected)
        {
            using var calendar = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, calendar.Handle);
            int invalidatedCallCount = 0;
            calendar.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            calendar.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            calendar.HandleCreated += (sender, e) => createdCallCount++;

            calendar.CalendarDimensions = value;
            Assert.Equal(expected, calendar.CalendarDimensions);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Set same.
            calendar.CalendarDimensions = value;
            Assert.Equal(expected, calendar.CalendarDimensions);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Theory]
        [InlineData(1, 12)]
        [InlineData(12, 1)]
        public void MonthCalendar_CalendarDimensions_SetWithHandleAreaOfTwelve_GetReturnsExpected(int width, int height)
        {
            var value = new Size(width, height);
            using var calendar = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, calendar.Handle);
            int invalidatedCallCount = 0;
            calendar.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            calendar.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            calendar.HandleCreated += (sender, e) => createdCallCount++;

            calendar.CalendarDimensions = value;
            Assert.True(calendar.CalendarDimensions.Width > 0 && calendar.CalendarDimensions.Width < 12);
            Assert.True(calendar.CalendarDimensions.Height > 0 && calendar.CalendarDimensions.Height < 12);
            Assert.NotEqual(value, calendar.CalendarDimensions);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Set same.
            calendar.CalendarDimensions = value;
            Assert.True(calendar.CalendarDimensions.Width > 0 && calendar.CalendarDimensions.Width < 12);
            Assert.True(calendar.CalendarDimensions.Height > 0 && calendar.CalendarDimensions.Height < 12);
            Assert.NotEqual(value, calendar.CalendarDimensions);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void MonthCalendar_CalendarDimensions_SetNegativeX_ThrowsArgumentOutOfRangeException(int x)
        {
            using var calendar = new MonthCalendar();
            Assert.Throws<ArgumentOutOfRangeException>("x", () => calendar.CalendarDimensions = new Size(x, 1));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void MonthCalendar_CalendarDimensions_SetNegativeY_ThrowsArgumentOutOfRangeException(int y)
        {
            using var calendar = new MonthCalendar();
            Assert.Throws<ArgumentOutOfRangeException>("y", () => calendar.CalendarDimensions = new Size(1, y));
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetBoolTheoryData))]
        public void MonthCalendar_DoubleBuffered_Set_GetReturnsExpected(bool value)
        {
            using var control = new SubMonthCalendar
            {
                DoubleBuffered = value
            };
            Assert.Equal(value, control.DoubleBuffered);
            Assert.Equal(value, control.GetStyle(ControlStyles.OptimizedDoubleBuffer));
            Assert.False(control.IsHandleCreated);

            // Set same.
            control.DoubleBuffered = value;
            Assert.Equal(value, control.DoubleBuffered);
            Assert.Equal(value, control.GetStyle(ControlStyles.OptimizedDoubleBuffer));
            Assert.False(control.IsHandleCreated);

            // Set different.
            control.DoubleBuffered = !value;
            Assert.Equal(!value, control.DoubleBuffered);
            Assert.Equal(!value, control.GetStyle(ControlStyles.OptimizedDoubleBuffer));
            Assert.False(control.IsHandleCreated);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetBoolTheoryData))]
        public void MonthCalendar_DoubleBuffered_SetWithHandle_GetReturnsExpected(bool value)
        {
            using var control = new SubMonthCalendar();
            Assert.NotEqual(IntPtr.Zero, control.Handle);
            int invalidatedCallCount = 0;
            control.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            control.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            control.HandleCreated += (sender, e) => createdCallCount++;

            control.DoubleBuffered = value;
            Assert.Equal(value, control.DoubleBuffered);
            Assert.Equal(value, control.GetStyle(ControlStyles.OptimizedDoubleBuffer));
            Assert.True(control.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Set same.
            control.DoubleBuffered = value;
            Assert.Equal(value, control.DoubleBuffered);
            Assert.Equal(value, control.GetStyle(ControlStyles.OptimizedDoubleBuffer));
            Assert.True(control.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Set different.
            control.DoubleBuffered = !value;
            Assert.Equal(!value, control.DoubleBuffered);
            Assert.Equal(!value, control.GetStyle(ControlStyles.OptimizedDoubleBuffer));
            Assert.True(control.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetEnumTypeTheoryData), typeof(Day))]
        public void MonthCalendar_FirstDayOfWeek_Set_GetReturnsExpected(Day value)
        {
            using var calendar = new MonthCalendar
            {
                FirstDayOfWeek = value
            };
            Assert.Equal(value, calendar.FirstDayOfWeek);
            Assert.False(calendar.IsHandleCreated);

            // Set same.
            calendar.FirstDayOfWeek = value;
            Assert.Equal(value, calendar.FirstDayOfWeek);
            Assert.False(calendar.IsHandleCreated);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetEnumTypeTheoryData), typeof(Day))]
        public void MonthCalendar_FirstDayOfWeek_SetWithCustomOldValue_GetReturnsExpected(Day value)
        {
            using var calendar = new MonthCalendar
            {
                FirstDayOfWeek = Day.Monday
            };

            calendar.FirstDayOfWeek = value;
            Assert.Equal(value, calendar.FirstDayOfWeek);
            Assert.False(calendar.IsHandleCreated);

            // Set same.
            calendar.FirstDayOfWeek = value;
            Assert.Equal(value, calendar.FirstDayOfWeek);
            Assert.False(calendar.IsHandleCreated);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetEnumTypeTheoryData), typeof(Day))]
        public void MonthCalendar_FirstDayOfWeek_SetWithHandle_GetReturnsExpected(Day value)
        {
            using var calendar = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, calendar.Handle);
            int invalidatedCallCount = 0;
            calendar.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            calendar.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            calendar.HandleCreated += (sender, e) => createdCallCount++;

            calendar.FirstDayOfWeek = value;
            Assert.Equal(value, calendar.FirstDayOfWeek);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Set same.
            calendar.FirstDayOfWeek = value;
            Assert.Equal(value, calendar.FirstDayOfWeek);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Theory]
        [InlineData(Day.Default, 1)]
        [InlineData(Day.Monday, 0)]
        [InlineData(Day.Tuesday, 0)]
        [InlineData(Day.Wednesday, 0)]
        [InlineData(Day.Thursday, 0)]
        [InlineData(Day.Friday, 0)]
        [InlineData(Day.Saturday, 0)]
        [InlineData(Day.Sunday, 0)]
        public void MonthCalendar_FirstDayOfWeek_SetWithHandleWithCustomOldValue_GetReturnsExpected(Day value, int expectedCreatedCallCount)
        {
            using var calendar = new MonthCalendar
            {
                FirstDayOfWeek = Day.Monday
            };
            Assert.NotEqual(IntPtr.Zero, calendar.Handle);
            int invalidatedCallCount = 0;
            calendar.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            calendar.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            calendar.HandleCreated += (sender, e) => createdCallCount++;

            calendar.FirstDayOfWeek = value;
            Assert.Equal(value, calendar.FirstDayOfWeek);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(expectedCreatedCallCount, createdCallCount);

            // Set same.
            calendar.FirstDayOfWeek = value;
            Assert.Equal(value, calendar.FirstDayOfWeek);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(expectedCreatedCallCount, createdCallCount);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetEnumTypeTheoryDataInvalid), typeof(Day))]
        public void MonthCalendar_FirstDayOfWeek_SetInvalidValue_ThrowsInvalidEnumArgumentException(Day value)
        {
            using var calendar = new MonthCalendar();
            Assert.Throws<InvalidEnumArgumentException>("FirstDayOfWeek", () => calendar.FirstDayOfWeek = value);
        }

        public static IEnumerable<object[]> ForeColor_Set_TestData()
        {
            yield return new object[] { Color.Empty, SystemColors.WindowText };
            yield return new object[] { Color.FromArgb(254, 1, 2, 3), Color.FromArgb(254, 1, 2, 3) };
            yield return new object[] { Color.White, Color.White };
            yield return new object[] { Color.Black, Color.Black };
            yield return new object[] { Color.Red, Color.Red };
        }

        [Theory]
        [MemberData(nameof(ForeColor_Set_TestData))]
        public void MonthCalendar_ForeColor_Set_GetReturnsExpected(Color value, Color expected)
        {
            using var control = new MonthCalendar
            {
                ForeColor = value
            };
            Assert.Equal(expected, control.ForeColor);
            Assert.False(control.IsHandleCreated);

            // Set same.
            control.ForeColor = value;
            Assert.Equal(expected, control.ForeColor);
            Assert.False(control.IsHandleCreated);
        }

        public static IEnumerable<object[]> ForeColor_SetWithHandle_TestData()
        {
            yield return new object[] { Color.Empty, SystemColors.WindowText, 0 };
            yield return new object[] { Color.FromArgb(254, 1, 2, 3), Color.FromArgb(254, 1, 2, 3), 1 };
            yield return new object[] { Color.White, Color.White, 1 };
            yield return new object[] { Color.Black, Color.Black, 1 };
            yield return new object[] { Color.Red, Color.Red, 1 };
        }

        [Theory]
        [MemberData(nameof(ForeColor_SetWithHandle_TestData))]
        public void MonthCalendar_ForeColor_SetWithHandle_GetReturnsExpected(Color value, Color expected, int expectedInvalidatedCallCount)
        {
            using var control = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, control.Handle);
            int invalidatedCallCount = 0;
            control.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            control.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            control.HandleCreated += (sender, e) => createdCallCount++;

            control.ForeColor = value;
            Assert.Equal(expected, control.ForeColor);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(expectedInvalidatedCallCount, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Set same.
            control.ForeColor = value;
            Assert.Equal(expected, control.ForeColor);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(expectedInvalidatedCallCount, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Fact]
        public void MonthCalendar_ForeColor_SetWithHandler_CallsForeColorChanged()
        {
            using var control = new MonthCalendar();
            int callCount = 0;
            EventHandler handler = (sender, e) =>
            {
                Assert.Same(control, sender);
                Assert.Same(EventArgs.Empty, e);
                callCount++;
            };
            control.ForeColorChanged += handler;

            // Set different.
            control.ForeColor = Color.Red;
            Assert.Equal(Color.Red, control.ForeColor);
            Assert.Equal(1, callCount);

            // Set same.
            control.ForeColor = Color.Red;
            Assert.Equal(Color.Red, control.ForeColor);
            Assert.Equal(1, callCount);

            // Set different.
            control.ForeColor = Color.Empty;
            Assert.Equal(SystemColors.WindowText, control.ForeColor);
            Assert.Equal(2, callCount);

            // Remove handler.
            control.ForeColorChanged -= handler;
            control.ForeColor = Color.Red;
            Assert.Equal(Color.Red, control.ForeColor);
            Assert.Equal(2, callCount);
        }

        public static IEnumerable<object[]> ImeMode_Set_TestData()
        {
            yield return new object[] { ImeMode.Inherit, ImeMode.NoControl };
            yield return new object[] { ImeMode.NoControl, ImeMode.NoControl };
            yield return new object[] { ImeMode.On, ImeMode.On };
            yield return new object[] { ImeMode.Off, ImeMode.Off };
            yield return new object[] { ImeMode.Disable, ImeMode.Disable };
            yield return new object[] { ImeMode.Hiragana, ImeMode.Hiragana };
            yield return new object[] { ImeMode.Katakana, ImeMode.Katakana };
            yield return new object[] { ImeMode.KatakanaHalf, ImeMode.KatakanaHalf };
            yield return new object[] { ImeMode.AlphaFull, ImeMode.AlphaFull };
            yield return new object[] { ImeMode.Alpha, ImeMode.Alpha };
            yield return new object[] { ImeMode.HangulFull, ImeMode.HangulFull };
            yield return new object[] { ImeMode.Hangul, ImeMode.Hangul };
            yield return new object[] { ImeMode.Close, ImeMode.Close };
            yield return new object[] { ImeMode.OnHalf, ImeMode.On };
        }

        [Theory]
        [MemberData(nameof(ImeMode_Set_TestData))]
        public void MonthCalendar_ImeMode_Set_GetReturnsExpected(ImeMode value, ImeMode expected)
        {
            using var control = new MonthCalendar
            {
                ImeMode = value
            };
            Assert.Equal(expected, control.ImeMode);
            Assert.False(control.IsHandleCreated);

            // Set same.
            control.ImeMode = value;
            Assert.Equal(expected, control.ImeMode);
            Assert.False(control.IsHandleCreated);
        }

        [Theory]
        [MemberData(nameof(ImeMode_Set_TestData))]
        public void MonthCalendar_ImeMode_SetWithHandle_GetReturnsExpected(ImeMode value, ImeMode expected)
        {
            using var control = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, control.Handle);
            int invalidatedCallCount = 0;
            control.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            control.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            control.HandleCreated += (sender, e) => createdCallCount++;

            control.ImeMode = value;
            Assert.Equal(expected, control.ImeMode);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Set same.
            control.ImeMode = value;
            Assert.Equal(expected, control.ImeMode);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Fact]
        public void MonthCalendar_ImeMode_SetWithHandler_CallsImeModeChanged()
        {
            using var control = new MonthCalendar();
            int callCount = 0;
            EventHandler handler = (sender, e) =>
            {
                Assert.Same(control, sender);
                Assert.Same(EventArgs.Empty, e);
                callCount++;
            };
            control.ImeModeChanged += handler;

            // Set different.
            control.ImeMode = ImeMode.On;
            Assert.Equal(ImeMode.On, control.ImeMode);
            Assert.Equal(0, callCount);

            // Set same.
            control.ImeMode = ImeMode.On;
            Assert.Equal(ImeMode.On, control.ImeMode);
            Assert.Equal(0, callCount);

            // Set different.
            control.ImeMode = ImeMode.Off;
            Assert.Equal(ImeMode.Off, control.ImeMode);
            Assert.Equal(0, callCount);

            // Remove handler.
            control.ImeModeChanged -= handler;
            control.ImeMode = ImeMode.Off;
            Assert.Equal(ImeMode.Off, control.ImeMode);
            Assert.Equal(0, callCount);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetEnumTypeTheoryDataInvalid), typeof(ImeMode))]
        public void MonthCalendar_ImeMode_SetInvalid_ThrowsInvalidEnumArgumentException(ImeMode value)
        {
            using var control = new MonthCalendar();
            Assert.Throws<InvalidEnumArgumentException>("value", () => control.ImeMode = value);
        }

        public static IEnumerable<object[]> MaxDate_Set_TestData()
        {
            yield return new object[] { new DateTime(1753, 1, 1), new DateTime(1753, 1, 1), new DateTime(1753, 1, 1) };
            yield return new object[] { new DateTime(2019, 1, 29), new DateTime(2019, 1, 29), new DateTime(2019, 1, 29) };
            yield return new object[] { new DateTime(9998, 12, 31), new DateTime(9998, 12, 31), DateTime.Now.Date };
            yield return new object[] { new DateTime(9999, 1, 1), new DateTime(9998, 12, 31), DateTime.Now.Date };
            yield return new object[] { DateTime.MaxValue, new DateTime(9998, 12, 31), DateTime.Now.Date };
        }

        [Theory]
        [MemberData(nameof(MaxDate_Set_TestData))]
        public void MonthCalendar_MaxDate_Set_GetReturnsExpected(DateTime value, DateTime expected, DateTime expectedSelection)
        {
            using var calendar = new MonthCalendar
            {
                MaxDate = value
            };
            Assert.Equal(expected, calendar.MaxDate);
            Assert.Equal(expectedSelection, calendar.SelectionStart);
            Assert.Equal(expectedSelection, calendar.SelectionEnd);
            Assert.False(calendar.IsHandleCreated);

            // Set same.
            calendar.MaxDate = value;
            Assert.Equal(expected, calendar.MaxDate);
            Assert.Equal(expectedSelection, calendar.SelectionStart);
            Assert.Equal(expectedSelection, calendar.SelectionEnd);
            Assert.False(calendar.IsHandleCreated);
        }

        [Theory]
        [MemberData(nameof(MaxDate_Set_TestData))]
        public void MonthCalendar_MaxDate_SetWithHandle_GetReturnsExpected(DateTime value, DateTime expected, DateTime expectedSelection)
        {
            using var calendar = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, calendar.Handle);
            int invalidatedCallCount = 0;
            calendar.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            calendar.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            calendar.HandleCreated += (sender, e) => createdCallCount++;

            calendar.MaxDate = value;
            Assert.Equal(expected, calendar.MaxDate);
            Assert.Equal(expectedSelection, calendar.SelectionStart);
            Assert.Equal(expectedSelection, calendar.SelectionEnd);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Set same.
            calendar.MaxDate = value;
            Assert.Equal(expected, calendar.MaxDate);
            Assert.Equal(expectedSelection, calendar.SelectionStart);
            Assert.Equal(expectedSelection, calendar.SelectionEnd);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Fact]
        public void MonthCalendar_MaxDate_SetLessThanMinDate_ThrowsArgumentOutOfRangeException()
        {
            using var calendar = new MonthCalendar();
            Assert.Throws<ArgumentOutOfRangeException>("value", () => calendar.MaxDate = calendar.MinDate.AddTicks(-1));
        }

        public static IEnumerable<object[]> MaxSelectionCount_Set_TestData()
        {
            yield return new object[] { 1 };
            yield return new object[] { 2 };
            yield return new object[] { 7 };
            yield return new object[] { 8 };
            yield return new object[] { int.MaxValue };
        }

        [Theory]
        [MemberData(nameof(MaxSelectionCount_Set_TestData))]
        public void MonthCalendar_MaxSelectionCount_Set_GetReturnsExpected(int value)
        {
            using var calendar = new MonthCalendar
            {
                MaxSelectionCount = value
            };
            Assert.Equal(value, calendar.MaxSelectionCount);
            Assert.False(calendar.IsHandleCreated);

            // Set same.
            calendar.MaxSelectionCount = value;
            Assert.Equal(value, calendar.MaxSelectionCount);
            Assert.False(calendar.IsHandleCreated);
        }

        [Theory]
        [MemberData(nameof(MaxSelectionCount_Set_TestData))]
        public void MonthCalendar_MaxSelectionCount_SetWithHandle_GetReturnsExpected(int value)
        {
            using var calendar = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, calendar.Handle);
            int invalidatedCallCount = 0;
            calendar.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            calendar.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            calendar.HandleCreated += (sender, e) => createdCallCount++;

            calendar.MaxSelectionCount = value;
            Assert.Equal(value, calendar.MaxSelectionCount);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Set same.
            calendar.MaxSelectionCount = value;
            Assert.Equal(value, calendar.MaxSelectionCount);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void MonthCalendar_MaxSelectionCount_SetLessThanOne_ThrowsArgumentOutOfRangeException(int value)
        {
            using var calendar = new MonthCalendar();
            Assert.Throws<ArgumentOutOfRangeException>("value", () => calendar.MaxSelectionCount = value);
        }

        public static IEnumerable<object[]> MinDate_Set_TestData()
        {
            yield return new object[] { DateTime.MinValue, new DateTime(1753, 1, 1), DateTime.Now.Date };
            yield return new object[] { new DateTime(1753, 1, 1), new DateTime(1753, 1, 1), DateTime.Now.Date };
            yield return new object[] { new DateTime(2019, 1, 29), new DateTime(2019, 1, 29), DateTime.Now.Date };
            yield return new object[] { new DateTime(9998, 12, 31), new DateTime(9998, 12, 31), new DateTime(9998, 12, 31) };
        }

        [Theory]
        [MemberData(nameof(MinDate_Set_TestData))]
        public void MonthCalendar_MinDate_Set_GetReturnsExpected(DateTime value, DateTime expected, DateTime expectedSelection)
        {
            using var calendar = new MonthCalendar
            {
                MinDate = value
            };
            Assert.Equal(expected, calendar.MinDate);
            Assert.Equal(expectedSelection, calendar.SelectionStart);
            Assert.Equal(expectedSelection, calendar.SelectionEnd);
            Assert.False(calendar.IsHandleCreated);

            // Set same.
            calendar.MinDate = value;
            Assert.Equal(expected, calendar.MinDate);
            Assert.Equal(expectedSelection, calendar.SelectionStart);
            Assert.Equal(expectedSelection, calendar.SelectionEnd);
            Assert.False(calendar.IsHandleCreated);
        }

        [Theory]
        [MemberData(nameof(MinDate_Set_TestData))]
        public void MonthCalendar_MinDate_SetWithHandle_GetReturnsExpected(DateTime value, DateTime expected, DateTime expectedSelection)
        {
            using var calendar = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, calendar.Handle);
            int invalidatedCallCount = 0;
            calendar.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            calendar.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            calendar.HandleCreated += (sender, e) => createdCallCount++;

            calendar.MinDate = value;
            Assert.Equal(expected, calendar.MinDate);
            Assert.Equal(expectedSelection, calendar.SelectionStart);
            Assert.Equal(expectedSelection, calendar.SelectionEnd);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Set same.
            calendar.MinDate = value;
            Assert.Equal(expected, calendar.MinDate);
            Assert.Equal(expectedSelection, calendar.SelectionStart);
            Assert.Equal(expectedSelection, calendar.SelectionEnd);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Fact]
        public void MonthCalendar_MinDate_SetLessThanMaxDate_ThrowsArgumentOutOfRangeException()
        {
            using var calendar = new MonthCalendar();
            Assert.Throws<ArgumentOutOfRangeException>("value", () => calendar.MinDate = calendar.MaxDate.AddTicks(1));
        }

        [Fact]
        public void MonthCalendar_MinDate_SetLessThanMinDate_ThrowsArgumentOutOfRangeException()
        {
            using var calendar = new MonthCalendar();
            Assert.Throws<ArgumentOutOfRangeException>("value", () => calendar.MinDate = calendar.MinDate.AddTicks(-1));
        }

        public static IEnumerable<object[]> MonthlyBoldedDates_Set_TestData()
        {
            yield return new object[] { null, new DateTime[0] };
            yield return new object[] { new DateTime[0], new DateTime[0] };

            yield return new object[] { new DateTime[] { new DateTime(2019, 01, 1), new DateTime(2019, 01, 20) }, new DateTime[] { new DateTime(2019, 01, 1), new DateTime(2019, 01, 20) } };
            yield return new object[] { new DateTime[] { new DateTime(2017, 01, 1), new DateTime(2018, 01, 20) }, new DateTime[] { new DateTime(2017, 01, 1), new DateTime(2018, 01, 20) } };
            yield return new object[] { new DateTime[] { new DateTime(2019, 01, 1), new DateTime(2019, 01, 1), new DateTime(2018, 01, 1) }, new DateTime[] { new DateTime(2019, 01, 1), new DateTime(2019, 01, 1), new DateTime(2018, 01, 1) } };
            yield return new object[] { new DateTime[] { DateTime.MinValue, DateTime.MaxValue }, new DateTime[] { DateTime.MinValue, DateTime.MaxValue } };

            var everyMonth = new DateTime[]
            {
                new DateTime(2019, 01, 1),
                new DateTime(2019, 02, 2),
                new DateTime(2019, 03, 3),
                new DateTime(2019, 04, 4),
                new DateTime(2019, 05, 5),
                new DateTime(2019, 06, 6),
                new DateTime(2019, 07, 7),
                new DateTime(2019, 08, 8),
                new DateTime(2019, 09, 9),
                new DateTime(2019, 10, 10),
                new DateTime(2019, 11, 11),
                new DateTime(2019, 12, 12),
            };
            yield return new object[] { everyMonth, everyMonth };
        }

        [Theory]
        [MemberData(nameof(MonthlyBoldedDates_Set_TestData))]
        public void MonthCalendar_MonthlyBoldedDates_Set_GetReturnsExpected(DateTime[] value, DateTime[] expected)
        {
            using var calendar = new MonthCalendar
            {
                MonthlyBoldedDates = value
            };
            Assert.Equal(expected, calendar.MonthlyBoldedDates);
            Assert.NotSame(value, calendar.MonthlyBoldedDates);
            Assert.NotSame(calendar.MonthlyBoldedDates, calendar.MonthlyBoldedDates);
            Assert.False(calendar.IsHandleCreated);

            // Set same.
            calendar.MonthlyBoldedDates = value;
            Assert.Equal(expected, calendar.MonthlyBoldedDates);
            Assert.NotSame(value, calendar.MonthlyBoldedDates);
            Assert.NotSame(calendar.MonthlyBoldedDates, calendar.MonthlyBoldedDates);
            Assert.False(calendar.IsHandleCreated);
        }

        [Theory]
        [MemberData(nameof(MonthlyBoldedDates_Set_TestData))]
        public void MonthCalendar_MonthlyBoldedDates_SetWithHandle_GetReturnsExpected(DateTime[] value, DateTime[] expected)
        {
            using var calendar = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, calendar.Handle);
            int invalidatedCallCount = 0;
            calendar.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            calendar.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            calendar.HandleCreated += (sender, e) => createdCallCount++;

            calendar.MonthlyBoldedDates = value;
            Assert.Equal(expected, calendar.MonthlyBoldedDates);
            Assert.NotSame(value, calendar.MonthlyBoldedDates);
            Assert.NotSame(calendar.MonthlyBoldedDates, calendar.MonthlyBoldedDates);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(1, createdCallCount);

            // Set same.
            calendar.MonthlyBoldedDates = value;
            Assert.Equal(expected, calendar.MonthlyBoldedDates);
            Assert.NotSame(value, calendar.MonthlyBoldedDates);
            Assert.NotSame(calendar.MonthlyBoldedDates, calendar.MonthlyBoldedDates);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(2, createdCallCount);
        }
        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetPaddingNormalizedTheoryData))]
        public void MonthCalendar_Padding_Set_GetReturnsExpected(Padding value, Padding expected)
        {
            using var control = new MonthCalendar
            {
                Padding = value
            };
            Assert.Equal(expected, control.Padding);
            Assert.False(control.IsHandleCreated);

            // Set same.
            control.Padding = value;
            Assert.Equal(expected, control.Padding);
            Assert.False(control.IsHandleCreated);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetPaddingNormalizedTheoryData))]
        public void MonthCalendar_Padding_SetWithHandle_GetReturnsExpected(Padding value, Padding expected)
        {
            using var control = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, control.Handle);
            int invalidatedCallCount = 0;
            control.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            control.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            control.HandleCreated += (sender, e) => createdCallCount++;

            control.Padding = value;
            Assert.Equal(expected, control.Padding);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Set same.
            control.Padding = value;
            Assert.Equal(expected, control.Padding);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Fact]
        public void MonthCalendar_Padding_SetWithHandler_CallsPaddingChanged()
        {
            using var control = new MonthCalendar();
            int callCount = 0;
            EventHandler handler = (sender, e) =>
            {
                Assert.Equal(control, sender);
                Assert.Equal(EventArgs.Empty, e);
                callCount++;
            };
            control.PaddingChanged += handler;

            // Set different.
            var padding1 = new Padding(1);
            control.Padding = padding1;
            Assert.Equal(padding1, control.Padding);
            Assert.Equal(1, callCount);

            // Set same.
            control.Padding = padding1;
            Assert.Equal(padding1, control.Padding);
            Assert.Equal(1, callCount);

            // Set different.
            var padding2 = new Padding(2);
            control.Padding = padding2;
            Assert.Equal(padding2, control.Padding);
            Assert.Equal(2, callCount);

            // Remove handler.
            control.PaddingChanged -= handler;
            control.Padding = padding1;
            Assert.Equal(padding1, control.Padding);
            Assert.Equal(2, callCount);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetBoolTheoryData))]
        public void MonthCalendar_RightToLeftLayout_Set_GetReturnsExpected(bool value)
        {
            using var control = new SubMonthCalendar
            {
                RightToLeftLayout = value
            };
            Assert.Equal(value, control.RightToLeftLayout);
            Assert.False(control.IsHandleCreated);

            // Set same.
            control.RightToLeftLayout = value;
            Assert.Equal(value, control.RightToLeftLayout);
            Assert.False(control.IsHandleCreated);

            // Set different.
            control.RightToLeftLayout = !value;
            Assert.Equal(!value, control.RightToLeftLayout);
            Assert.False(control.IsHandleCreated);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetBoolTheoryData))]
        public void MonthCalendar_RightToLeftLayout_SetWithRightToLeftYes_GetReturnsExpected(bool value)
        {
            using var control = new SubMonthCalendar
            {
                RightToLeft = RightToLeft.Yes,
                RightToLeftLayout = value
            };
            Assert.Equal(value, control.RightToLeftLayout);
            Assert.False(control.IsHandleCreated);

            // Set same.
            control.RightToLeftLayout = value;
            Assert.Equal(value, control.RightToLeftLayout);
            Assert.False(control.IsHandleCreated);

            // Set different.
            control.RightToLeftLayout = !value;
            Assert.Equal(!value, control.RightToLeftLayout);
            Assert.False(control.IsHandleCreated);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetBoolTheoryData))]
        public void MonthCalendar_RightToLeftLayout_SetWithHandle_GetReturnsExpected(bool value)
        {
            using var control = new SubMonthCalendar();
            Assert.NotEqual(IntPtr.Zero, control.Handle);
            int invalidatedCallCount = 0;
            control.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            control.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            control.HandleCreated += (sender, e) => createdCallCount++;

            control.RightToLeftLayout = value;
            Assert.Equal(value, control.RightToLeftLayout);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Set same.
            control.RightToLeftLayout = value;
            Assert.Equal(value, control.RightToLeftLayout);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Set different.
            control.RightToLeftLayout = !value;
            Assert.Equal(!value, control.RightToLeftLayout);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Theory]
        [InlineData(true, 1)]
        [InlineData(false, 0)]
        public void MonthCalendar_RightToLeftLayout_SetWithHandleWithRightToLeftYes_GetReturnsExpected(bool value, int expectedCreatedCallCount)
        {
            using var control = new SubMonthCalendar
            {
                RightToLeft = RightToLeft.Yes
            };
            Assert.NotEqual(IntPtr.Zero, control.Handle);
            int invalidatedCallCount = 0;
            control.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            control.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            control.HandleCreated += (sender, e) => createdCallCount++;

            control.RightToLeftLayout = value;
            Assert.Equal(value, control.RightToLeftLayout);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(expectedCreatedCallCount, createdCallCount);

            // Set same.
            control.RightToLeftLayout = value;
            Assert.Equal(value, control.RightToLeftLayout);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(expectedCreatedCallCount, createdCallCount);

            // Set different.
            control.RightToLeftLayout = !value;
            Assert.Equal(!value, control.RightToLeftLayout);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(expectedCreatedCallCount + 1, createdCallCount);
        }

        [Fact]
        public void MonthCalendar_RightToLeftLayout_SetWithHandler_CallsRightToLeftLayoutChanged()
        {
            var calendar = new MonthCalendar
            {
                RightToLeftLayout = true
            };
            int callCount = 0;
            EventHandler handler = (sender, e) =>
            {
                Assert.Same(calendar, sender);
                Assert.Same(EventArgs.Empty, e);
                callCount++;
            };
            calendar.RightToLeftLayoutChanged += handler;

            // Set different.
            calendar.RightToLeftLayout = false;
            Assert.False(calendar.RightToLeftLayout);
            Assert.Equal(1, callCount);

            // Set same.
            calendar.RightToLeftLayout = false;
            Assert.False(calendar.RightToLeftLayout);
            Assert.Equal(1, callCount);

            // Set different.
            calendar.RightToLeftLayout = true;
            Assert.True(calendar.RightToLeftLayout);
            Assert.Equal(2, callCount);

            // Remove handler.
            calendar.RightToLeftLayoutChanged -= handler;
            calendar.RightToLeftLayout = false;
            Assert.False(calendar.RightToLeftLayout);
            Assert.Equal(2, callCount);
        }

        [Fact]
        public void MonthCalendar_RightToLeftLayout_SetWithHandlerInDisposing_DoesNotRightToLeftLayoutChanged()
        {
            using var control = new MonthCalendar
            {
                RightToLeft = RightToLeft.Yes
            };
            Assert.NotEqual(IntPtr.Zero, control.Handle);

            int callCount = 0;
            control.RightToLeftLayoutChanged += (sender, e) => callCount++;
            int createdCallCount = 0;
            control.HandleCreated += (sender, e) => createdCallCount++;

            int disposedCallCount = 0;
            control.Disposed += (sender, e) =>
            {
                control.RightToLeftLayout = true;
                Assert.True(control.RightToLeftLayout);
                Assert.Equal(0, callCount);
                Assert.Equal(0, createdCallCount);
                disposedCallCount++;
            };

            control.Dispose();
            Assert.Equal(1, disposedCallCount);
        }

        public static IEnumerable<object[]> ScrollChange_Set_TestData()
        {
            yield return new object[] { 0 };
            yield return new object[] { 1 };
            yield return new object[] { 2 };
            yield return new object[] { 20000 };
        }

        [Theory]
        [MemberData(nameof(ScrollChange_Set_TestData))]
        public void MonthCalendar_ScrollChange_Set_GetReturnsExpected(int value)
        {
            using var calendar = new MonthCalendar
            {
                ScrollChange = value
            };
            Assert.Equal(value, calendar.ScrollChange);
            Assert.False(calendar.IsHandleCreated);

            // Set same.
            calendar.ScrollChange = value;
            Assert.Equal(value, calendar.ScrollChange);
            Assert.False(calendar.IsHandleCreated);
        }

        [Theory]
        [MemberData(nameof(ScrollChange_Set_TestData))]
        public void MonthCalendar_ScrollChange_SetWithHandle_GetReturnsExpected(int value)
        {
            using var calendar = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, calendar.Handle);
            int invalidatedCallCount = 0;
            calendar.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            calendar.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            calendar.HandleCreated += (sender, e) => createdCallCount++;

            calendar.ScrollChange = value;
            Assert.Equal(value, calendar.ScrollChange);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Set same.
            calendar.ScrollChange = value;
            Assert.Equal(value, calendar.ScrollChange);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(200001)]
        public void MonthCalendar_ScrollChange_SetInvalid_ThrowsArgumentOutOfRangeException(int value)
        {
            using var calendar = new MonthCalendar();
            Assert.Throws<ArgumentOutOfRangeException>("value", () => calendar.ScrollChange = value);
        }

        public static IEnumerable<object[]> SelectionStart_Set_TestData()
        {
            yield return new object[] { DateTime.MinValue, new DateTime(1, 1, 7) };
            yield return new object[] { new DateTime(1753, 1, 1), new DateTime(1753, 1, 7) };
            yield return new object[] { new DateTime(1753, 1, 1).AddHours(1), new DateTime(1753, 1, 7).AddHours(1) };
            yield return new object[] { new DateTime(2019, 1, 29), new DateTime(2019, 2, 4) };
            yield return new object[] { DateTime.Now.Date.AddDays(-1), DateTime.Now.Date };
            yield return new object[] { DateTime.Now.Date, DateTime.Now.Date };
            yield return new object[] { new DateTime(9998, 12, 31), new DateTime(9998, 12, 31) };
            yield return new object[] { DateTime.MaxValue, DateTime.MaxValue };
        }

        [Theory]
        [MemberData(nameof(SelectionStart_Set_TestData))]
        public void MonthCalendar_SelectionStart_Set_GetReturnsExpected(DateTime value, DateTime expectedSelectionEnd)
        {
            using var calendar = new MonthCalendar
            {
                SelectionStart = value
            };
            Assert.Equal(value, calendar.SelectionStart);
            Assert.Equal(expectedSelectionEnd, calendar.SelectionEnd);
            Assert.False(calendar.IsHandleCreated);

            // Set same.
            calendar.SelectionStart = value;
            Assert.Equal(value, calendar.SelectionStart);
            Assert.Equal(expectedSelectionEnd, calendar.SelectionEnd);
            Assert.False(calendar.IsHandleCreated);
        }

        [Theory]
        [MemberData(nameof(SelectionStart_Set_TestData))]
        public void MonthCalendar_SelectionStart_SetWithHandle_GetReturnsExpected(DateTime value, DateTime expectedSelectionEnd)
        {
            using var calendar = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, calendar.Handle);
            int invalidatedCallCount = 0;
            calendar.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            calendar.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            calendar.HandleCreated += (sender, e) => createdCallCount++;

            calendar.SelectionStart = value;
            Assert.Equal(value, calendar.SelectionStart);
            Assert.Equal(expectedSelectionEnd, calendar.SelectionEnd);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Set same.
            calendar.SelectionStart = value;
            Assert.Equal(value, calendar.SelectionStart);
            Assert.Equal(expectedSelectionEnd, calendar.SelectionEnd);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Fact]
        public void MonthCalendar_SelectionStart_SetLessThanMinDate_ThrowsArgumentOutOfRangeException()
        {
            using var calendar = new MonthCalendar();
            calendar.SelectionStart = calendar.MinDate.AddTicks(-1);
            Assert.Equal(calendar.MinDate.AddTicks(-1), calendar.SelectionStart);

            calendar.MinDate = new DateTime(2019, 10, 3);
            Assert.Throws<ArgumentOutOfRangeException>("value", () => calendar.SelectionStart = calendar.MinDate.AddTicks(-1));
        }

        [Fact]
        public void MonthCalendar_SelectionStart_SetGreaterThanMaxDate_ThrowsArgumentOutOfRangeException()
        {
            using var calendar = new MonthCalendar();
            calendar.SelectionStart = calendar.MaxDate.AddTicks(1);
            Assert.Equal(calendar.MaxDate.AddTicks(1), calendar.SelectionStart);

            calendar.MaxDate = new DateTime(2019, 9, 3);
            Assert.Throws<ArgumentOutOfRangeException>("value", () => calendar.SelectionStart = calendar.MaxDate.AddTicks(1));
        }
        public static IEnumerable<object[]> SelectionEnd_Set_TestData()
        {
            yield return new object[] { new DateTime(1753, 1, 1), new DateTime(1753, 1, 1) };
            yield return new object[] { new DateTime(1753, 1, 1).AddHours(1), new DateTime(1753, 1, 1).AddHours(1) };
            yield return new object[] { new DateTime(2019, 1, 29), new DateTime(2019, 1, 29) };
            yield return new object[] { DateTime.Now.Date.AddDays(1), DateTime.Now.Date };
            yield return new object[] { DateTime.Now.Date, DateTime.Now.Date };
            yield return new object[] { new DateTime(9998, 12, 31), new DateTime(9998, 12, 25) };
        }

        [Theory]
        [MemberData(nameof(SelectionEnd_Set_TestData))]
        public void MonthCalendar_SelectionEnd_Set_GetReturnsExpected(DateTime value, DateTime expectedSelectionStart)
        {
            using var calendar = new MonthCalendar
            {
                SelectionEnd = value
            };
            Assert.Equal(value, calendar.SelectionEnd);
            Assert.Equal(expectedSelectionStart, calendar.SelectionStart);
            Assert.False(calendar.IsHandleCreated);

            // Set same.
            calendar.SelectionEnd = value;
            Assert.Equal(value, calendar.SelectionEnd);
            Assert.Equal(expectedSelectionStart, calendar.SelectionStart);
            Assert.False(calendar.IsHandleCreated);
        }

        [Theory]
        [MemberData(nameof(SelectionEnd_Set_TestData))]
        public void MonthCalendar_SelectionEnd_SetWithHandle_GetReturnsExpected(DateTime value, DateTime expectedSelectionStart)
        {
            using var calendar = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, calendar.Handle);
            int invalidatedCallCount = 0;
            calendar.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            calendar.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            calendar.HandleCreated += (sender, e) => createdCallCount++;

            calendar.SelectionEnd = value;
            Assert.Equal(value, calendar.SelectionEnd);
            Assert.Equal(expectedSelectionStart, calendar.SelectionStart);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Set same.
            calendar.SelectionEnd = value;
            Assert.Equal(value, calendar.SelectionEnd);
            Assert.Equal(expectedSelectionStart, calendar.SelectionStart);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Fact]
        public void MonthCalendar_SelectionEnd_SetLessThanMinDate_ThrowsArgumentOutOfRangeException()
        {
            using var calendar = new MonthCalendar();
            Assert.Throws<ArgumentOutOfRangeException>("value", () => calendar.SelectionEnd = calendar.MinDate.AddTicks(-1));

            calendar.MinDate = new DateTime(2019, 10, 3);
            Assert.Throws<ArgumentOutOfRangeException>("value", () => calendar.SelectionEnd = calendar.MinDate.AddTicks(-1));
        }

        [Fact]
        public void MonthCalendar_SelectionEnd_SetGreaterThanMaxDate_ThrowsArgumentOutOfRangeException()
        {
            using var calendar = new MonthCalendar();
            Assert.Throws<ArgumentOutOfRangeException>("value", () => calendar.SelectionEnd = calendar.MaxDate.AddTicks(1));

            calendar.MaxDate = new DateTime(2019, 9, 3);
            Assert.Throws<ArgumentOutOfRangeException>("value", () => calendar.SelectionEnd = calendar.MaxDate.AddTicks(1));
        }

        public static IEnumerable<object[]> SelectionRange_Set_TestData()
        {
            yield return new object[] { new SelectionRange(DateTime.MinValue, DateTime.MinValue), DateTime.MinValue, DateTime.MinValue };
            yield return new object[] { new SelectionRange(new DateTime(1753, 1, 1).AddTicks(-1), new DateTime(1753, 1, 1).AddTicks(-1)), new DateTime(1752, 12, 31), new DateTime(1752, 12, 31) };
            yield return new object[] { new SelectionRange(new DateTime(1753, 1, 1), new DateTime(1753, 1, 1)), new DateTime(1753, 1, 1), new DateTime(1753, 1, 1) };
            yield return new object[] { new SelectionRange(new DateTime(1753, 1, 1), new DateTime(1753, 1, 2)), new DateTime(1753, 1, 1), new DateTime(1753, 1, 2) };

            yield return new object[] { new SelectionRange(new DateTime(2019, 9, 1), new DateTime(2019, 9, 1)), new DateTime(2019, 9, 1), new DateTime(2019, 9, 1) };
            yield return new object[] { new SelectionRange(new DateTime(2019, 9, 1), new DateTime(2019, 9, 2)), new DateTime(2019, 9, 1), new DateTime(2019, 9, 2) };
            yield return new object[] { new SelectionRange(new DateTime(2019, 9, 1).AddHours(1), new DateTime(2019, 9, 2).AddHours(1)), new DateTime(2019, 9, 1), new DateTime(2019, 9, 2) };
            yield return new object[] { new SelectionRange(new DateTime(2019, 9, 2), new DateTime(2019, 9, 1)), new DateTime(2019, 9, 1), new DateTime(2019, 9, 2) };
            yield return new object[] { new SelectionRange(new DateTime(2019, 9, 1), new DateTime(2019, 9, 7)), new DateTime(2019, 9, 1), new DateTime(2019, 9, 7) };
            yield return new object[] { new SelectionRange(new DateTime(2019, 9, 1), new DateTime(2019, 9, 8)), new DateTime(2019, 9, 1), new DateTime(2019, 9, 7) };

            yield return new object[] { new SelectionRange(DateTime.Now.Date, DateTime.Now.Date), DateTime.Now.Date, DateTime.Now.Date };
            yield return new object[] { new SelectionRange(DateTime.Now.Date, DateTime.Now.Date.AddDays(1)), DateTime.Now.Date, DateTime.Now.Date.AddDays(1) };
            yield return new object[] { new SelectionRange(DateTime.Now.Date.AddHours(1), DateTime.Now.Date.AddHours(1)), DateTime.Now.Date, DateTime.Now.Date };
            yield return new object[] { new SelectionRange(DateTime.Now.Date.AddDays(1), DateTime.Now.Date), DateTime.Now.Date, DateTime.Now.Date.AddDays(1) };
            yield return new object[] { new SelectionRange(DateTime.Now.Date, DateTime.Now.Date.AddDays(6)), DateTime.Now.Date, DateTime.Now.Date.AddDays(6) };
            yield return new object[] { new SelectionRange(DateTime.Now.Date, DateTime.Now.Date.AddDays(7)), DateTime.Now.Date.AddDays(1), DateTime.Now.Date.AddDays(7) };

            yield return new object[] { new SelectionRange(new DateTime(9998, 12, 30), new DateTime(9998, 12, 31)), new DateTime(9998, 12, 30), new DateTime(9998, 12, 31) };
            yield return new object[] { new SelectionRange(new DateTime(9998, 12, 31), new DateTime(9998, 12, 31)), new DateTime(9998, 12, 31), new DateTime(9998, 12, 31) };
            yield return new object[] { new SelectionRange(new DateTime(9998, 12, 31).AddTicks(1), new DateTime(9998, 12, 31).AddTicks(1)), new DateTime(9998, 12, 31), new DateTime(9998, 12, 31) };
            yield return new object[] { new SelectionRange(DateTime.MaxValue, DateTime.MaxValue), DateTime.MaxValue.Date, DateTime.MaxValue.Date };
        }

        [Theory]
        [MemberData(nameof(SelectionRange_Set_TestData))]
        public void MonthCalendar_SelectionRange_Set_GetReturnsExpected(SelectionRange value, DateTime expectedSelectionStart, DateTime expectedSelectionEnd)
        {
            using var calendar = new MonthCalendar
            {
                SelectionRange = value
            };
            Assert.Equal(expectedSelectionStart, calendar.SelectionRange.Start);
            Assert.Equal(expectedSelectionEnd, calendar.SelectionRange.End);
            Assert.Equal(expectedSelectionStart, calendar.SelectionStart);
            Assert.Equal(expectedSelectionEnd, calendar.SelectionEnd);
            Assert.NotSame(value, calendar.SelectionRange);
            Assert.False(calendar.IsHandleCreated);

            // Set same.
            calendar.SelectionRange = new SelectionRange(expectedSelectionStart, expectedSelectionEnd);
            Assert.Equal(expectedSelectionStart, calendar.SelectionRange.Start);
            Assert.Equal(expectedSelectionEnd, calendar.SelectionRange.End);
            Assert.Equal(expectedSelectionStart, calendar.SelectionStart);
            Assert.Equal(expectedSelectionEnd, calendar.SelectionEnd);
            Assert.NotSame(value, calendar.SelectionRange);
            Assert.False(calendar.IsHandleCreated);
        }

        [Theory]
        [MemberData(nameof(SelectionRange_Set_TestData))]
        public void MonthCalendar_SelectionRange_SetWithHandle_GetReturnsExpected(SelectionRange value, DateTime expectedSelectionStart, DateTime expectedSelectionEnd)
        {
            using var calendar = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, calendar.Handle);
            int invalidatedCallCount = 0;
            calendar.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            calendar.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            calendar.HandleCreated += (sender, e) => createdCallCount++;

            calendar.SelectionRange = value;
            Assert.Equal(expectedSelectionStart, calendar.SelectionRange.Start);
            Assert.Equal(expectedSelectionEnd, calendar.SelectionRange.End);
            Assert.Equal(expectedSelectionStart, calendar.SelectionStart);
            Assert.Equal(expectedSelectionEnd, calendar.SelectionEnd);
            Assert.NotSame(value, calendar.SelectionRange);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Set same.
            calendar.SelectionRange = new SelectionRange(expectedSelectionStart, expectedSelectionEnd);
            Assert.Equal(expectedSelectionStart, calendar.SelectionRange.Start);
            Assert.Equal(expectedSelectionEnd, calendar.SelectionRange.End);
            Assert.Equal(expectedSelectionStart, calendar.SelectionStart);
            Assert.Equal(expectedSelectionEnd, calendar.SelectionEnd);
            Assert.NotSame(value, calendar.SelectionRange);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Fact]
        public void MonthCalendar_SelectionRange_SetLessThanMinDate_ThrowsArgumentOutOfRangeException()
        {
            using var calendar = new MonthCalendar();
            calendar.SelectionRange = new SelectionRange(calendar.MinDate.AddTicks(-1), calendar.MinDate);
            Assert.Equal(calendar.MinDate.AddTicks(-1).Date, calendar.SelectionStart);
            Assert.Equal(calendar.MinDate, calendar.SelectionEnd);

            calendar.SelectionRange = new SelectionRange(calendar.MinDate, calendar.MinDate.AddTicks(-1));
            Assert.Equal(calendar.MinDate.AddTicks(-1).Date, calendar.SelectionStart);
            Assert.Equal(calendar.MinDate, calendar.SelectionEnd);

            calendar.MinDate = new DateTime(2019, 10, 3);
            Assert.Throws<ArgumentOutOfRangeException>("date1", () => calendar.SelectionRange = new SelectionRange(calendar.MinDate.AddTicks(-1), calendar.MinDate));
            Assert.Throws<ArgumentOutOfRangeException>("date1", () => calendar.SelectionRange = new SelectionRange(calendar.MinDate, calendar.MinDate.AddTicks(-1)));
        }

        [Fact]
        public void MonthCalendar_SelectionRange_SetGreaterThanMaxDate_ThrowsArgumentOutOfRangeException()
        {
            using var calendar = new MonthCalendar();
            calendar.SelectionRange = new SelectionRange(calendar.MaxDate.AddTicks(1), calendar.MaxDate);
            Assert.Equal(calendar.MaxDate, calendar.SelectionStart);
            Assert.Equal(calendar.MaxDate.AddTicks(1).Date, calendar.SelectionEnd);

            calendar.SelectionRange = new SelectionRange(calendar.MaxDate, calendar.MaxDate.AddTicks(1));
            Assert.Equal(calendar.MaxDate, calendar.SelectionStart);
            Assert.Equal(calendar.MaxDate.AddTicks(1).Date, calendar.SelectionEnd);

            calendar.MaxDate = new DateTime(2019, 9, 3);
            Assert.Throws<ArgumentOutOfRangeException>("date2", () => calendar.SelectionRange = new SelectionRange(calendar.MaxDate.AddDays(1), calendar.MaxDate));
            Assert.Throws<ArgumentOutOfRangeException>("date2", () => calendar.SelectionRange = new SelectionRange(calendar.MaxDate, calendar.MaxDate.AddDays(1)));
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetBoolTheoryData))]
        public void MonthCalendar_ShowToday_Set_GetReturnsExpected(bool value)
        {
            using var control = new SubMonthCalendar
            {
                ShowToday = value
            };
            Assert.Equal(value, control.ShowToday);
            Assert.False(control.IsHandleCreated);

            // Set same.
            control.ShowToday = value;
            Assert.Equal(value, control.ShowToday);
            Assert.False(control.IsHandleCreated);

            // Set different.
            control.ShowToday = !value;
            Assert.Equal(!value, control.ShowToday);
            Assert.False(control.IsHandleCreated);
        }

        [Theory]
        [InlineData(true, 0)]
        [InlineData(false, 1)]
        public void MonthCalendar_ShowToday_SetWithHandle_GetReturnsExpected(bool value, int expectedStyleChangedCallCount)
        {
            using var control = new SubMonthCalendar();
            Assert.NotEqual(IntPtr.Zero, control.Handle);
            int invalidatedCallCount = 0;
            control.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            control.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            control.HandleCreated += (sender, e) => createdCallCount++;

            control.ShowToday = value;
            Assert.Equal(value, control.ShowToday);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(expectedStyleChangedCallCount, invalidatedCallCount);
            Assert.Equal(expectedStyleChangedCallCount, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Set same.
            control.ShowToday = value;
            Assert.Equal(value, control.ShowToday);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(expectedStyleChangedCallCount, invalidatedCallCount);
            Assert.Equal(expectedStyleChangedCallCount, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Set different.
            control.ShowToday = !value;
            Assert.Equal(!value, control.ShowToday);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(expectedStyleChangedCallCount + 1, invalidatedCallCount);
            Assert.Equal(expectedStyleChangedCallCount + 1, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Fact]
        public void MonthCalendar_CreateAccessibilityInstance_Invoke_ReturnsExpected()
        {
            using var control = new SubMonthCalendar();
            AccessibleObject instance = control.CreateAccessibilityInstance();
            Assert.NotNull(instance);
            Assert.NotSame(control.CreateAccessibilityInstance(), instance);
            Assert.NotSame(control.AccessibilityObject, instance);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetBoolTheoryData))]
        public void MonthCalendar_ShowTodayCircle_Set_GetReturnsExpected(bool value)
        {
            using var control = new SubMonthCalendar
            {
                ShowTodayCircle = value
            };
            Assert.Equal(value, control.ShowTodayCircle);
            Assert.False(control.IsHandleCreated);

            // Set same.
            control.ShowTodayCircle = value;
            Assert.Equal(value, control.ShowTodayCircle);
            Assert.False(control.IsHandleCreated);

            // Set different.
            control.ShowTodayCircle = !value;
            Assert.Equal(!value, control.ShowTodayCircle);
            Assert.False(control.IsHandleCreated);
        }

        [Theory]
        [InlineData(true, 0)]
        [InlineData(false, 1)]
        public void MonthCalendar_ShowTodayCircle_SetWithHandle_GetReturnsExpected(bool value, int expectedStyleChangedCallCount)
        {
            using var control = new SubMonthCalendar();
            Assert.NotEqual(IntPtr.Zero, control.Handle);
            int invalidatedCallCount = 0;
            control.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            control.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            control.HandleCreated += (sender, e) => createdCallCount++;

            control.ShowTodayCircle = value;
            Assert.Equal(value, control.ShowTodayCircle);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(expectedStyleChangedCallCount, invalidatedCallCount);
            Assert.Equal(expectedStyleChangedCallCount, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Set same.
            control.ShowTodayCircle = value;
            Assert.Equal(value, control.ShowTodayCircle);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(expectedStyleChangedCallCount, invalidatedCallCount);
            Assert.Equal(expectedStyleChangedCallCount, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Set different.
            control.ShowTodayCircle = !value;
            Assert.Equal(!value, control.ShowTodayCircle);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(expectedStyleChangedCallCount + 1, invalidatedCallCount);
            Assert.Equal(expectedStyleChangedCallCount + 1, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetBoolTheoryData))]
        public void MonthCalendar_ShowWeekNumbers_Set_GetReturnsExpected(bool value)
        {
            using var control = new SubMonthCalendar
            {
                ShowWeekNumbers = value
            };
            Assert.Equal(value, control.ShowWeekNumbers);
            Assert.False(control.IsHandleCreated);

            // Set same.
            control.ShowWeekNumbers = value;
            Assert.Equal(value, control.ShowWeekNumbers);
            Assert.False(control.IsHandleCreated);

            // Set different.
            control.ShowWeekNumbers = !value;
            Assert.Equal(!value, control.ShowWeekNumbers);
            Assert.False(control.IsHandleCreated);
        }

        [Theory]
        [InlineData(true, 1)]
        [InlineData(false, 0)]
        public void MonthCalendar_ShowWeekNumbers_SetWithHandle_GetReturnsExpected(bool value, int expectedStyleChangedCallCount)
        {
            using var control = new SubMonthCalendar();
            Assert.NotEqual(IntPtr.Zero, control.Handle);
            int invalidatedCallCount = 0;
            control.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            control.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            control.HandleCreated += (sender, e) => createdCallCount++;

            control.ShowWeekNumbers = value;
            Assert.Equal(value, control.ShowWeekNumbers);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(expectedStyleChangedCallCount, invalidatedCallCount);
            Assert.Equal(expectedStyleChangedCallCount, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Set same.
            control.ShowWeekNumbers = value;
            Assert.Equal(value, control.ShowWeekNumbers);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(expectedStyleChangedCallCount, invalidatedCallCount);
            Assert.Equal(expectedStyleChangedCallCount, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Set different.
            control.ShowWeekNumbers = !value;
            Assert.Equal(!value, control.ShowWeekNumbers);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(expectedStyleChangedCallCount + 1, invalidatedCallCount);
            Assert.Equal(expectedStyleChangedCallCount + 1, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Fact]
        public void MonthCalendar_SingleMonthSize_GetWithHandle_ReturnsExpected()
        {
            using var control = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, control.Handle);

            Size size = control.SingleMonthSize;
            Assert.True(size.Width > 0);
            Assert.True(size.Height > 0);
            Assert.Equal(size, control.SingleMonthSize);
        }

        public static IEnumerable<object[]> Size_Set_TestData()
        {
            yield return new object[] { new Size(1, 2) };
            yield return new object[] { new Size(0, 0) };
            yield return new object[] { new Size(-1, -2) };
            yield return new object[] { new Size(-1, 2) };
            yield return new object[] { new Size(1, -2) };
        }

        [Theory]
        [MemberData(nameof(Size_Set_TestData))]
        public void MonthCalendar_Size_Set_GetReturnsExpected(Size value)
        {
            using var control = new MonthCalendar();
            Size size = control.ClientSize;

            control.Size = value;
            Assert.Equal(size, control.ClientSize);
            Assert.Equal(new Rectangle(Point.Empty, size), control.ClientRectangle);
            Assert.Equal(new Rectangle(Point.Empty, size), control.DisplayRectangle);
            Assert.Equal(size, control.Size);
            Assert.Equal(new Rectangle(Point.Empty, size), control.Bounds);
            Assert.False(control.IsHandleCreated);

            // Set same.
            control.Size = value;
            Assert.Equal(size, control.ClientSize);
            Assert.Equal(new Rectangle(Point.Empty, size), control.ClientRectangle);
            Assert.Equal(new Rectangle(Point.Empty, size), control.DisplayRectangle);
            Assert.Equal(size, control.Size);
            Assert.Equal(new Rectangle(Point.Empty, size), control.Bounds);
            Assert.False(control.IsHandleCreated);
        }

        [Theory]
        [MemberData(nameof(Size_Set_TestData))]
        public void MonthCalendar_Size_SetWithHandle_GetReturnsExpected(Size value)
        {
            using var control = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, control.Handle);
            Size size = control.Size;

            int invalidatedCallCount = 0;
            control.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            control.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            control.HandleCreated += (sender, e) => createdCallCount++;

            control.Size = value;
            Assert.Equal(size, control.ClientSize);
            Assert.Equal(new Rectangle(Point.Empty, size), control.ClientRectangle);
            Assert.Equal(new Rectangle(Point.Empty, size), control.DisplayRectangle);
            Assert.Equal(size, control.Size);
            Assert.Equal(new Rectangle(Point.Empty, size), control.Bounds);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Set same.
            control.Size = value;
            Assert.Equal(size, control.ClientSize);
            Assert.Equal(new Rectangle(Point.Empty, size), control.ClientRectangle);
            Assert.Equal(new Rectangle(Point.Empty, size), control.DisplayRectangle);
            Assert.Equal(size, control.Size);
            Assert.Equal(new Rectangle(Point.Empty, size), control.Bounds);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Fact]
        public void MonthCalendar_Size_SetWithHandler_CallsSizeChanged()
        {
            using var control = new MonthCalendar();
            Size size = control.Size;

            int callCount = 0;
            EventHandler handler = (sender, e) =>
            {
                Assert.Same(control, sender);
                Assert.Same(EventArgs.Empty, e);
                callCount++;
            };
            int clientSizeChangedCallCount = 0;
            EventHandler clientSizeChangedHandler = (sender, e) =>
            {
                Assert.Same(control, sender);
                Assert.Same(EventArgs.Empty, e);
                clientSizeChangedCallCount++;
            };
            control.SizeChanged += handler;
            control.ClientSizeChanged += clientSizeChangedHandler;

            control.Size = new Size(10, 10);
            Assert.Equal(size, control.Size);
            Assert.Equal(0, callCount);
            Assert.Equal(0, clientSizeChangedCallCount);

            // Set same.
            control.Size = new Size(10, 10);
            Assert.Equal(size, control.Size);
            Assert.Equal(0, callCount);
            Assert.Equal(0, clientSizeChangedCallCount);

            // Set different.
            control.Size = new Size(11, 11);
            Assert.Equal(size, control.Size);
            Assert.Equal(0, callCount);
            Assert.Equal(0, clientSizeChangedCallCount);

            // Remove handler.
            control.SizeChanged -= handler;
            control.ClientSizeChanged -= clientSizeChangedHandler;
            control.Size = new Size(10, 10);
            Assert.Equal(size, control.Size);
            Assert.Equal(0, callCount);
            Assert.Equal(0, clientSizeChangedCallCount);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetStringNormalizedTheoryData))]
        public void MonthCalendar_Text_Set_GetReturnsExpected(string value, string expected)
        {
            using var control = new MonthCalendar
            {
                Text = value
            };
            Assert.Equal(expected, control.Text);
            Assert.False(control.IsHandleCreated);

            // Set same.
            control.Text = value;
            Assert.Equal(expected, control.Text);
            Assert.False(control.IsHandleCreated);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetStringNormalizedTheoryData))]
        public void MonthCalendar_Text_SetWithHandle_GetReturnsExpected(string value, string expected)
        {
            using var control = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, control.Handle);
            int invalidatedCallCount = 0;
            control.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            control.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            control.HandleCreated += (sender, e) => createdCallCount++;

            control.Text = value;
            Assert.Equal(expected, control.Text);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Set same.
            control.Text = value;
            Assert.Equal(expected, control.Text);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Fact]
        public void MonthCalendar_Text_SetWithHandler_CallsTextChanged()
        {
            using var control = new MonthCalendar();
            int callCount = 0;
            EventHandler handler = (sender, e) =>
            {
                Assert.Same(control, sender);
                Assert.Equal(EventArgs.Empty, e);
                callCount++;
            };
            control.TextChanged += handler;

            // Set different.
            control.Text = "text";
            Assert.Same("text", control.Text);
            Assert.Equal(1, callCount);

            // Set same.
            control.Text = "text";
            Assert.Same("text", control.Text);
            Assert.Equal(1, callCount);

            // Set different.
            control.Text = null;
            Assert.Empty(control.Text);
            Assert.Equal(2, callCount);

            // Remove handler.
            control.TextChanged -= handler;
            control.Text = "text";
            Assert.Same("text", control.Text);
            Assert.Equal(2, callCount);
        }

        public static IEnumerable<object[]> TitleBackColor_Set_TestData()
        {
            yield return new object[] { Color.Red };
            yield return new object[] { Color.FromArgb(254, 1, 2, 3) };
        }

        [Theory]
        [MemberData(nameof(TitleBackColor_Set_TestData))]
        public void MonthCalendar_TitleBackColor_Set_GetReturnsExpected(Color value)
        {
            using var calendar = new MonthCalendar
            {
                TitleBackColor = value
            };
            Assert.Equal(value, calendar.TitleBackColor);
            Assert.False(calendar.IsHandleCreated);

            // Call again.
            calendar.TitleBackColor = value;
            Assert.Equal(value, calendar.TitleBackColor);
            Assert.False(calendar.IsHandleCreated);
        }

        [Theory]
        [MemberData(nameof(TitleBackColor_Set_TestData))]
        public void MonthCalendar_TitleBackColor_SetWithHandle_GetReturnsExpected(Color value)
        {
            using var calendar = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, calendar.Handle);
            int invalidatedCallCount = 0;
            calendar.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            calendar.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            calendar.HandleCreated += (sender, e) => createdCallCount++;

            calendar.TitleBackColor = value;
            Assert.Equal(value, calendar.TitleBackColor);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Call again.
            calendar.TitleBackColor = value;
            Assert.Equal(value, calendar.TitleBackColor);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Fact]
        public void MonthCalendar_TitleBackColor_SetEmpty_ThrowsArgumentException()
        {
            using var calendar = new MonthCalendar();
            Assert.Throws<ArgumentException>(null, () => calendar.TitleBackColor = Color.Empty);
        }

        public static IEnumerable<object[]> TitleForeColor_Set_TestData()
        {
            yield return new object[] { Color.Red };
            yield return new object[] { Color.FromArgb(254, 1, 2, 3) };
        }

        [Theory]
        [MemberData(nameof(TitleForeColor_Set_TestData))]
        public void MonthCalendar_TitleForeColor_Set_GetReturnsExpected(Color value)
        {
            using var calendar = new MonthCalendar
            {
                TitleForeColor = value
            };
            Assert.Equal(value, calendar.TitleForeColor);
            Assert.False(calendar.IsHandleCreated);

            // Call again.
            calendar.TitleForeColor = value;
            Assert.Equal(value, calendar.TitleForeColor);
            Assert.False(calendar.IsHandleCreated);
        }

        [Theory]
        [MemberData(nameof(TitleForeColor_Set_TestData))]
        public void MonthCalendar_TitleForeColor_SetWithHandle_GetReturnsExpected(Color value)
        {
            using var calendar = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, calendar.Handle);
            int invalidatedCallCount = 0;
            calendar.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            calendar.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            calendar.HandleCreated += (sender, e) => createdCallCount++;

            calendar.TitleForeColor = value;
            Assert.Equal(value, calendar.TitleForeColor);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Call again.
            calendar.TitleForeColor = value;
            Assert.Equal(value, calendar.TitleForeColor);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Fact]
        public void MonthCalendar_TitleForeColor_SetEmpty_ThrowsArgumentException()
        {
            using var calendar = new MonthCalendar();
            Assert.Throws<ArgumentException>(null, () => calendar.TitleForeColor = Color.Empty);
        }

        [Fact]
        public void MonthCalendar_TodayDate_GetWithHandle_ReturnsExpected()
        {
            using var control = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, control.Handle);
            Assert.Equal(DateTime.Now.Date, control.TodayDate);
            Assert.False(control.TodayDateSet);
        }

        public static IEnumerable<object[]> TodayDate_Set_TestData()
        {
            yield return new object[] { DateTime.MinValue };
            yield return new object[] { new DateTime(1753, 1, 1).AddTicks(-1) };
            yield return new object[] { new DateTime(1753, 1, 1) };
            yield return new object[] { new DateTime(2019, 9, 1) };
            yield return new object[] { new DateTime(2019, 9, 1).AddHours(1) };
            yield return new object[] { DateTime.Now.Date };
            yield return new object[] { DateTime.Now.Date.AddHours(1) };
            yield return new object[] { new DateTime(9998, 12, 31) };
            yield return new object[] { new DateTime(9998, 12, 31).AddTicks(1) };
            yield return new object[] { DateTime.MaxValue };
        }

        [Theory]
        [MemberData(nameof(TodayDate_Set_TestData))]
        public void MonthCalendar_TodayDate_Set_GetReturnsExpected(DateTime value)
        {
            using var calendar = new MonthCalendar
            {
                TodayDate = value
            };
            Assert.Equal(value.Date, calendar.TodayDate);
            Assert.True(calendar.TodayDateSet);
            Assert.False(calendar.IsHandleCreated);

            // Call again.
            calendar.TodayDate = value;
            Assert.Equal(value.Date, calendar.TodayDate);
            Assert.True(calendar.TodayDateSet);
            Assert.False(calendar.IsHandleCreated);
        }

        [Theory]
        [MemberData(nameof(TodayDate_Set_TestData))]
        public void MonthCalendar_TodayDate_SetWithHandle_GetReturnsExpected(DateTime value)
        {
            using var calendar = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, calendar.Handle);
            int invalidatedCallCount = 0;
            calendar.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            calendar.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            calendar.HandleCreated += (sender, e) => createdCallCount++;

            calendar.TodayDate = value;
            Assert.Equal(value.Date, calendar.TodayDate);
            Assert.True(calendar.TodayDateSet);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Call again.
            calendar.TodayDate = value;
            Assert.Equal(value.Date, calendar.TodayDate);
            Assert.True(calendar.TodayDateSet);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Fact]
        public void MonthCalendar_TodayDate_SetLessThanMinDate_ThrowsArgumentOutOfRangeException()
        {
            using var calendar = new MonthCalendar();
            calendar.TodayDate = calendar.MinDate.AddTicks(-1);
            Assert.Equal(calendar.MinDate.AddTicks(-1).Date, calendar.TodayDate);

            calendar.MinDate = new DateTime(2019, 10, 3);
            Assert.Throws<ArgumentOutOfRangeException>("value", () => calendar.TodayDate = calendar.MinDate.AddTicks(-1));
        }

        [Fact]
        public void MonthCalendar_TodayDate_SetGreaterThanMaxDate_ThrowsArgumentOutOfRangeException()
        {
            using var calendar = new MonthCalendar();
            calendar.TodayDate = calendar.MaxDate.AddTicks(1);
            Assert.Equal(calendar.MaxDate.AddTicks(1).Date, calendar.TodayDate);

            calendar.MaxDate = new DateTime(2019, 9, 3);
            Assert.Throws<ArgumentOutOfRangeException>("value", () => calendar.TodayDate = calendar.MaxDate.AddDays(1));
        }

        public static IEnumerable<object[]> TrailingForeColor_Set_TestData()
        {
            yield return new object[] { Color.Red };
            yield return new object[] { Color.FromArgb(254, 1, 2, 3) };
        }

        [Theory]
        [MemberData(nameof(TrailingForeColor_Set_TestData))]
        public void MonthCalendar_TrailingForeColor_Set_GetReturnsExpected(Color value)
        {
            using var calendar = new MonthCalendar
            {
                TrailingForeColor = value
            };
            Assert.Equal(value, calendar.TrailingForeColor);
            Assert.False(calendar.IsHandleCreated);

            // Call again.
            calendar.TrailingForeColor = value;
            Assert.Equal(value, calendar.TrailingForeColor);
            Assert.False(calendar.IsHandleCreated);
        }

        [Theory]
        [MemberData(nameof(TrailingForeColor_Set_TestData))]
        public void MonthCalendar_TrailingForeColor_SetWithHandle_GetReturnsExpected(Color value)
        {
            using var calendar = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, calendar.Handle);
            int invalidatedCallCount = 0;
            calendar.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            calendar.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            calendar.HandleCreated += (sender, e) => createdCallCount++;

            calendar.TrailingForeColor = value;
            Assert.Equal(value, calendar.TrailingForeColor);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Call again.
            calendar.TrailingForeColor = value;
            Assert.Equal(value, calendar.TrailingForeColor);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Fact]
        public void MonthCalendar_TrailingForeColor_SetEmpty_ThrowsArgumentException()
        {
            using var calendar = new MonthCalendar();
            Assert.Throws<ArgumentException>(null, () => calendar.TrailingForeColor = Color.Empty);
        }

        [Fact]
        public void MonthCalendar_AddAnnuallyBoldedDate_Invoke_AddsToAnnuallyBoldedDates()
        {
            using var calendar = new MonthCalendar();
            calendar.AddAnnuallyBoldedDate(new DateTime(2019, 10, 3));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3) }, calendar.AnnuallyBoldedDates);
            Assert.False(calendar.IsHandleCreated);

            // Different day.
            calendar.AddAnnuallyBoldedDate(new DateTime(2019, 10, 5));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5) }, calendar.AnnuallyBoldedDates);
            Assert.False(calendar.IsHandleCreated);

            // Different month.
            calendar.AddAnnuallyBoldedDate(new DateTime(2019, 09, 5));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5) }, calendar.AnnuallyBoldedDates);
            Assert.False(calendar.IsHandleCreated);

            // Different year.
            calendar.AddAnnuallyBoldedDate(new DateTime(2018, 09, 5));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5), new DateTime(2018, 09, 5) }, calendar.AnnuallyBoldedDates);
            Assert.False(calendar.IsHandleCreated);

            // Duplicate.
            calendar.AddAnnuallyBoldedDate(new DateTime(2018, 09, 5));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5), new DateTime(2018, 09, 5), new DateTime(2018, 09, 5) }, calendar.AnnuallyBoldedDates);
            Assert.False(calendar.IsHandleCreated);

            // MinValue.
            calendar.AddAnnuallyBoldedDate(DateTime.MinValue);
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5), new DateTime(2018, 09, 5), new DateTime(2018, 09, 5), DateTime.MinValue }, calendar.AnnuallyBoldedDates);
            Assert.False(calendar.IsHandleCreated);

            // MaxValue.
            calendar.AddAnnuallyBoldedDate(DateTime.MaxValue);
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5), new DateTime(2018, 09, 5), new DateTime(2018, 09, 5), DateTime.MinValue, DateTime.MaxValue }, calendar.AnnuallyBoldedDates);
            Assert.False(calendar.IsHandleCreated);
        }

        [Fact]
        public void MonthCalendar_AddAnnuallyBoldedDate_InvokeWithHandle_AddsToAnnuallyBoldedDates()
        {
            using var calendar = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, calendar.Handle);
            int invalidatedCallCount = 0;
            calendar.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            calendar.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            calendar.HandleCreated += (sender, e) => createdCallCount++;

            calendar.AddAnnuallyBoldedDate(new DateTime(2019, 10, 3));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3) }, calendar.AnnuallyBoldedDates);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Different day.
            calendar.AddAnnuallyBoldedDate(new DateTime(2019, 10, 5));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5) }, calendar.AnnuallyBoldedDates);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Different month.
            calendar.AddAnnuallyBoldedDate(new DateTime(2019, 09, 5));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5) }, calendar.AnnuallyBoldedDates);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Different year.
            calendar.AddAnnuallyBoldedDate(new DateTime(2018, 09, 5));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5), new DateTime(2018, 09, 5) }, calendar.AnnuallyBoldedDates);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Duplicate.
            calendar.AddAnnuallyBoldedDate(new DateTime(2018, 09, 5));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5), new DateTime(2018, 09, 5), new DateTime(2018, 09, 5) }, calendar.AnnuallyBoldedDates);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // MinValue.
            calendar.AddAnnuallyBoldedDate(DateTime.MinValue);
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5), new DateTime(2018, 09, 5), new DateTime(2018, 09, 5), DateTime.MinValue }, calendar.AnnuallyBoldedDates);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // MaxValue.
            calendar.AddAnnuallyBoldedDate(DateTime.MaxValue);
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5), new DateTime(2018, 09, 5), new DateTime(2018, 09, 5), DateTime.MinValue, DateTime.MaxValue }, calendar.AnnuallyBoldedDates);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Fact]
        public void MonthCalendar_AddBoldedDate_Invoke_AddsToBoldedDates()
        {
            using var calendar = new MonthCalendar();
            calendar.AddBoldedDate(new DateTime(2019, 10, 3));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3) }, calendar.BoldedDates);
            Assert.False(calendar.IsHandleCreated);

            // Different day.
            calendar.AddBoldedDate(new DateTime(2019, 10, 5));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5) }, calendar.BoldedDates);
            Assert.False(calendar.IsHandleCreated);

            // Different month.
            calendar.AddBoldedDate(new DateTime(2019, 09, 5));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5) }, calendar.BoldedDates);
            Assert.False(calendar.IsHandleCreated);

            // Different year.
            calendar.AddBoldedDate(new DateTime(2018, 09, 5));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5), new DateTime(2018, 09, 5) }, calendar.BoldedDates);
            Assert.False(calendar.IsHandleCreated);

            // Duplicate.
            calendar.AddBoldedDate(new DateTime(2018, 09, 5));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5), new DateTime(2018, 09, 5) }, calendar.BoldedDates);
            Assert.False(calendar.IsHandleCreated);

            // MinValue.
            calendar.AddBoldedDate(DateTime.MinValue);
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5), new DateTime(2018, 09, 5), DateTime.MinValue }, calendar.BoldedDates);
            Assert.False(calendar.IsHandleCreated);

            // MaxValue.
            calendar.AddBoldedDate(DateTime.MaxValue);
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5), new DateTime(2018, 09, 5), DateTime.MinValue, DateTime.MaxValue }, calendar.BoldedDates);
            Assert.False(calendar.IsHandleCreated);
        }

        [Fact]
        public void MonthCalendar_AddBoldedDate_InvokeWithHandle_AddsToBoldedDates()
        {
            using var calendar = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, calendar.Handle);
            int invalidatedCallCount = 0;
            calendar.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            calendar.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            calendar.HandleCreated += (sender, e) => createdCallCount++;

            calendar.AddBoldedDate(new DateTime(2019, 10, 3));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3) }, calendar.BoldedDates);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Different day.
            calendar.AddBoldedDate(new DateTime(2019, 10, 5));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5) }, calendar.BoldedDates);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Different month.
            calendar.AddBoldedDate(new DateTime(2019, 09, 5));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5) }, calendar.BoldedDates);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Different year.
            calendar.AddBoldedDate(new DateTime(2018, 09, 5));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5), new DateTime(2018, 09, 5) }, calendar.BoldedDates);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Duplicate.
            calendar.AddBoldedDate(new DateTime(2018, 09, 5));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5), new DateTime(2018, 09, 5) }, calendar.BoldedDates);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // MinValue.
            calendar.AddBoldedDate(DateTime.MinValue);
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5), new DateTime(2018, 09, 5), DateTime.MinValue }, calendar.BoldedDates);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // MaxValue.
            calendar.AddBoldedDate(DateTime.MaxValue);
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5), new DateTime(2018, 09, 5), DateTime.MinValue, DateTime.MaxValue }, calendar.BoldedDates);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Fact]
        public void MonthCalendar_AddMonthlyBoldedDate_Invoke_AddsToMonthlyBoldedDates()
        {
            using var calendar = new MonthCalendar();
            calendar.AddMonthlyBoldedDate(new DateTime(2019, 10, 3));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3) }, calendar.MonthlyBoldedDates);
            Assert.False(calendar.IsHandleCreated);

            // Different day.
            calendar.AddMonthlyBoldedDate(new DateTime(2019, 10, 5));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5) }, calendar.MonthlyBoldedDates);
            Assert.False(calendar.IsHandleCreated);

            // Different month.
            calendar.AddMonthlyBoldedDate(new DateTime(2019, 09, 5));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5) }, calendar.MonthlyBoldedDates);
            Assert.False(calendar.IsHandleCreated);

            // Different year.
            calendar.AddMonthlyBoldedDate(new DateTime(2018, 09, 5));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5), new DateTime(2018, 09, 5) }, calendar.MonthlyBoldedDates);
            Assert.False(calendar.IsHandleCreated);

            // Duplicate.
            calendar.AddMonthlyBoldedDate(new DateTime(2018, 09, 5));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5), new DateTime(2018, 09, 5), new DateTime(2018, 09, 5) }, calendar.MonthlyBoldedDates);
            Assert.False(calendar.IsHandleCreated);

            // MinValue.
            calendar.AddMonthlyBoldedDate(DateTime.MinValue);
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5), new DateTime(2018, 09, 5), new DateTime(2018, 09, 5), DateTime.MinValue }, calendar.MonthlyBoldedDates);
            Assert.False(calendar.IsHandleCreated);

            // MaxValue.
            calendar.AddMonthlyBoldedDate(DateTime.MaxValue);
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5), new DateTime(2018, 09, 5), new DateTime(2018, 09, 5), DateTime.MinValue, DateTime.MaxValue }, calendar.MonthlyBoldedDates);
            Assert.False(calendar.IsHandleCreated);
        }

        [Fact]
        public void MonthCalendar_AddMonthlyBoldedDate_InvokeWithHandle_AddsToMonthlyBoldedDates()
        {
            using var calendar = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, calendar.Handle);
            int invalidatedCallCount = 0;
            calendar.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            calendar.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            calendar.HandleCreated += (sender, e) => createdCallCount++;

            calendar.AddMonthlyBoldedDate(new DateTime(2019, 10, 3));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3) }, calendar.MonthlyBoldedDates);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Different day.
            calendar.AddMonthlyBoldedDate(new DateTime(2019, 10, 5));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5) }, calendar.MonthlyBoldedDates);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Different month.
            calendar.AddMonthlyBoldedDate(new DateTime(2019, 09, 5));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5) }, calendar.MonthlyBoldedDates);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Different year.
            calendar.AddMonthlyBoldedDate(new DateTime(2018, 09, 5));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5), new DateTime(2018, 09, 5) }, calendar.MonthlyBoldedDates);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Duplicate.
            calendar.AddMonthlyBoldedDate(new DateTime(2018, 09, 5));
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5), new DateTime(2018, 09, 5), new DateTime(2018, 09, 5) }, calendar.MonthlyBoldedDates);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // MinValue.
            calendar.AddMonthlyBoldedDate(DateTime.MinValue);
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5), new DateTime(2018, 09, 5), new DateTime(2018, 09, 5), DateTime.MinValue }, calendar.MonthlyBoldedDates);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // MaxValue.
            calendar.AddMonthlyBoldedDate(DateTime.MaxValue);
            Assert.Equal(new DateTime[] { new DateTime(2019, 10, 3), new DateTime(2019, 10, 5), new DateTime(2019, 09, 5), new DateTime(2018, 09, 5), new DateTime(2018, 09, 5), DateTime.MinValue, DateTime.MaxValue }, calendar.MonthlyBoldedDates);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Fact]
        public void MonthCalendar_CreateHandle_Invoke_Success()
        {
            using var control = new SubMonthCalendar();
            control.CreateHandle();
            Assert.True(control.Created);
            Assert.True(control.IsHandleCreated);
            Assert.NotEqual(IntPtr.Zero, control.Handle);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetEventArgsTheoryData))]
        public void MonthCalendar_OnBackColorChanged_Invoke_CallsBackColorChanged(EventArgs eventArgs)
        {
            using var control = new SubMonthCalendar();
            int callCount = 0;
            EventHandler handler = (sender, e) =>
            {
                Assert.Same(control, sender);
                Assert.Same(eventArgs, e);
                callCount++;
            };

            // Call with handler.
            control.BackColorChanged += handler;
            control.OnBackColorChanged(eventArgs);
            Assert.Equal(1, callCount);
            Assert.False(control.IsHandleCreated);

            // Remove handler.
            control.BackColorChanged -= handler;
            control.OnBackColorChanged(eventArgs);
            Assert.Equal(1, callCount);
            Assert.False(control.IsHandleCreated);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetEventArgsTheoryData))]
        public void MonthCalendar_OnBackColorChanged_InvokeWithHandle_CallsBackColorChanged(EventArgs eventArgs)
        {
            using var control = new SubMonthCalendar();
            Assert.NotEqual(IntPtr.Zero, control.Handle);

            int callCount = 0;
            EventHandler handler = (sender, e) =>
            {
                Assert.Same(control, sender);
                Assert.Same(eventArgs, e);
                callCount++;
            };
            int invalidatedCallCount = 0;
            InvalidateEventHandler invalidatedHandler = (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            EventHandler styleChangedHandler = (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            EventHandler createdHandler = (sender, e) => createdCallCount++;

            // Call with handler.
            control.BackColorChanged += handler;
            control.Invalidated += invalidatedHandler;
            control.StyleChanged += styleChangedHandler;
            control.HandleCreated += createdHandler;
            control.OnBackColorChanged(eventArgs);
            Assert.Equal(1, callCount);
            Assert.Equal(1, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
            Assert.True(control.IsHandleCreated);

            // Remove handler.
            control.BackColorChanged -= handler;
            control.Invalidated -= invalidatedHandler;
            control.StyleChanged -= styleChangedHandler;
            control.HandleCreated -= createdHandler;
            control.OnBackColorChanged(eventArgs);
            Assert.Equal(1, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
            Assert.True(control.IsHandleCreated);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetEventArgsTheoryData))]
        public void MonthCalendar_OnClick_Invoke_CallsClick(EventArgs eventArgs)
        {
            using var control = new SubMonthCalendar();
            int callCount = 0;
            EventHandler handler = (sender, e) =>
            {
                Assert.Same(control, sender);
                Assert.Same(eventArgs, e);
                callCount++;
            };

            // Call with handler.
            control.Click += handler;
            control.OnClick(eventArgs);
            Assert.Equal(1, callCount);

            // Remove handler.
            control.Click -= handler;
            control.OnClick(eventArgs);
            Assert.Equal(1, callCount);
        }

        public static IEnumerable<object[]> DateRangeEventArgs_TestData()
        {
            yield return new object[] { null };
            yield return new object[] { new DateRangeEventArgs(DateTime.Now, DateTime.Now) };
        }

        [Theory]
        [MemberData(nameof(DateRangeEventArgs_TestData))]
        public void MonthCalendar_Calendar_OnDateChanged_Invoke_CallsDateChanged(DateRangeEventArgs eventArgs)
        {
            using var calendar = new SubMonthCalendar();
            int callCount = 0;
            DateRangeEventHandler handler = (sender, e) =>
            {
                Assert.Same(calendar, sender);
                Assert.Same(eventArgs, e);
                callCount++;
            };

            // Call with handler.
            calendar.DateChanged += handler;
            calendar.OnDateChanged(eventArgs);
            Assert.Equal(1, callCount);

            // Remove handler.
            calendar.DateChanged -= handler;
            calendar.OnDateChanged(eventArgs);
            Assert.Equal(1, callCount);
        }

        [Theory]
        [MemberData(nameof(DateRangeEventArgs_TestData))]
        public void MonthCalendar_Calendar_OnDateSelected_Invoke_CallsDateSelected(DateRangeEventArgs eventArgs)
        {
            using var calendar = new SubMonthCalendar();
            int callCount = 0;
            DateRangeEventHandler handler = (sender, e) =>
            {
                Assert.Same(calendar, sender);
                Assert.Same(eventArgs, e);
                callCount++;
            };

            // Call with handler.
            calendar.DateSelected += handler;
            calendar.OnDateSelected(eventArgs);
            Assert.Equal(1, callCount);

            // Remove handler.
            calendar.DateSelected -= handler;
            calendar.OnDateSelected(eventArgs);
            Assert.Equal(1, callCount);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetEventArgsTheoryData))]
        public void MonthControl_OnDoubleClick_Invoke_CallsDoubleClick(EventArgs eventArgs)
        {
            using var control = new SubMonthCalendar();
            int callCount = 0;
            EventHandler handler = (sender, e) =>
            {
                Assert.Same(control, sender);
                Assert.Same(eventArgs, e);
                callCount++;
            };

            // Call with handler.
            control.DoubleClick += handler;
            control.OnDoubleClick(eventArgs);
            Assert.Equal(1, callCount);

            // Remove handler.
            control.DoubleClick -= handler;
            control.OnDoubleClick(eventArgs);
            Assert.Equal(1, callCount);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetEventArgsTheoryData))]
        public void MonthCalendar_OnForeColorChanged_Invoke_CallsForeColorChanged(EventArgs eventArgs)
        {
            using var control = new SubMonthCalendar();
            int callCount = 0;
            EventHandler handler = (sender, e) =>
            {
                Assert.Same(control, sender);
                Assert.Same(eventArgs, e);
                callCount++;
            };

            // Call with handler.
            control.ForeColorChanged += handler;
            control.OnForeColorChanged(eventArgs);
            Assert.Equal(1, callCount);
            Assert.False(control.IsHandleCreated);

            // Remove handler.
            control.ForeColorChanged -= handler;
            control.OnForeColorChanged(eventArgs);
            Assert.Equal(1, callCount);
            Assert.False(control.IsHandleCreated);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetEventArgsTheoryData))]
        public void MonthCalendar_OnForeColorChanged_InvokeWithHandle_CallsForeColorChanged(EventArgs eventArgs)
        {
            using var control = new SubMonthCalendar();
            Assert.NotEqual(IntPtr.Zero, control.Handle);

            int callCount = 0;
            EventHandler handler = (sender, e) =>
            {
                Assert.Same(control, sender);
                Assert.Same(eventArgs, e);
                callCount++;
            };
            int invalidatedCallCount = 0;
            InvalidateEventHandler invalidatedHandler = (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            EventHandler styleChangedHandler = (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            EventHandler createdHandler = (sender, e) => createdCallCount++;

            // Call with handler.
            control.ForeColorChanged += handler;
            control.Invalidated += invalidatedHandler;
            control.StyleChanged += styleChangedHandler;
            control.HandleCreated += createdHandler;
            control.OnForeColorChanged(eventArgs);
            Assert.Equal(1, callCount);
            Assert.Equal(1, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
            Assert.True(control.IsHandleCreated);

            // Remove handler.
            control.ForeColorChanged -= handler;
            control.Invalidated -= invalidatedHandler;
            control.StyleChanged -= styleChangedHandler;
            control.HandleCreated -= createdHandler;
            control.OnForeColorChanged(eventArgs);
            Assert.Equal(1, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
            Assert.True(control.IsHandleCreated);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetMouseEventArgsTheoryData))]
        public void MonthCalendar_OnMouseClick_Invoke_CallsMouseClick(MouseEventArgs eventArgs)
        {
            using var control = new SubMonthCalendar();
            int callCount = 0;
            MouseEventHandler handler = (sender, e) =>
            {
                Assert.Same(control, sender);
                Assert.Same(eventArgs, e);
                callCount++;
            };

            // Call with handler.
            control.MouseClick += handler;
            control.OnMouseClick(eventArgs);
            Assert.Equal(1, callCount);

            // Remove handler.
            control.MouseClick -= handler;
            control.OnMouseClick(eventArgs);
            Assert.Equal(1, callCount);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetMouseEventArgsTheoryData))]
        public void MonthCalendar_OnMouseDoubleClick_Invoke_CallsMouseDoubleClick(MouseEventArgs eventArgs)
        {
            using var control = new SubMonthCalendar();
            int callCount = 0;
            MouseEventHandler handler = (sender, e) =>
            {
                Assert.Same(control, sender);
                Assert.Same(eventArgs, e);
                callCount++;
            };

            // Call with handler.
            control.MouseDoubleClick += handler;
            control.OnMouseDoubleClick(eventArgs);
            Assert.Equal(1, callCount);

            // Remove handler.
            control.MouseDoubleClick -= handler;
            control.OnMouseDoubleClick(eventArgs);
            Assert.Equal(1, callCount);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetPaintEventArgsTheoryData))]
        public void MonthCalendar_OnPaint_Invoke_CallsPaint(PaintEventArgs eventArgs)
        {
            using var control = new SubMonthCalendar();
            int callCount = 0;
            PaintEventHandler handler = (sender, e) =>
            {
                Assert.Same(control, sender);
                Assert.Same(eventArgs, e);
                callCount++;
            };

            // Call with handler.
            control.Paint += handler;
            control.OnPaint(eventArgs);
            Assert.Equal(1, callCount);

            // Remove handler.
            control.Paint -= handler;
            control.OnPaint(eventArgs);
            Assert.Equal(1, callCount);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetEventArgsTheoryData))]
        public void MonthCalendar_OnRightToLeftLayoutChanged_Invoke_CallsRightToLeftLayoutChanged(EventArgs eventArgs)
        {
            using var control = new SubMonthCalendar();
            int callCount = 0;
            EventHandler handler = (sender, e) =>
            {
                Assert.Same(control, sender);
                Assert.Same(eventArgs, e);
                callCount++;
            };

            // Call with handler.
            control.RightToLeftLayoutChanged += handler;
            control.OnRightToLeftLayoutChanged(eventArgs);
            Assert.Equal(1, callCount);
            Assert.False(control.IsHandleCreated);

            // Remove handler.
            control.RightToLeftLayoutChanged -= handler;
            control.OnRightToLeftLayoutChanged(eventArgs);
            Assert.Equal(1, callCount);
            Assert.False(control.IsHandleCreated);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetEventArgsTheoryData))]
        public void MonthCalendar_OnRightToLeftLayoutChanged_InvokeWithRightToLeftYes_CallsRightToLeftLayoutChanged(EventArgs eventArgs)
        {
            using var control = new SubMonthCalendar
            {
                RightToLeft = RightToLeft.Yes
            };
            int callCount = 0;
            EventHandler handler = (sender, e) =>
            {
                Assert.Same(control, sender);
                Assert.Same(eventArgs, e);
                callCount++;
            };

            // Call with handler.
            control.RightToLeftLayoutChanged += handler;
            control.OnRightToLeftLayoutChanged(eventArgs);
            Assert.Equal(1, callCount);
            Assert.False(control.IsHandleCreated);

            // Remove handler.
            control.RightToLeftLayoutChanged -= handler;
            control.OnRightToLeftLayoutChanged(eventArgs);
            Assert.Equal(1, callCount);
            Assert.False(control.IsHandleCreated);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetEventArgsTheoryData))]
        public void MonthCalendar_OnRightToLeftLayoutChanged_InvokeWithHandle_CallsRightToLeftLayoutChanged(EventArgs eventArgs)
        {
            using var control = new SubMonthCalendar();
            Assert.NotEqual(IntPtr.Zero, control.Handle);

            int callCount = 0;
            EventHandler handler = (sender, e) =>
            {
                Assert.Same(control, sender);
                Assert.Same(eventArgs, e);
                callCount++;
            };
            int invalidatedCallCount = 0;
            InvalidateEventHandler invalidatedHandler = (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            EventHandler styleChangedHandler = (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            EventHandler createdHandler = (sender, e) => createdCallCount++;

            // Call with handler.
            control.RightToLeftLayoutChanged += handler;
            control.Invalidated += invalidatedHandler;
            control.StyleChanged += styleChangedHandler;
            control.HandleCreated += createdHandler;
            control.OnRightToLeftLayoutChanged(eventArgs);
            Assert.Equal(1, callCount);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Remove handler.
            control.RightToLeftLayoutChanged -= handler;
            control.Invalidated -= invalidatedHandler;
            control.StyleChanged -= styleChangedHandler;
            control.HandleCreated -= createdHandler;
            control.OnRightToLeftLayoutChanged(eventArgs);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Theory]
        [CommonMemberData(nameof(CommonTestHelper.GetEventArgsTheoryData))]
        public void MonthCalendar_OnRightToLeftLayoutChanged_InvokeWithHandleWithRightToLeftYes_CallsRightToLeftLayoutChanged(EventArgs eventArgs)
        {
            using var control = new SubMonthCalendar
            {
                RightToLeft = RightToLeft.Yes
            };
            Assert.NotEqual(IntPtr.Zero, control.Handle);

            int callCount = 0;
            EventHandler handler = (sender, e) =>
            {
                Assert.Same(control, sender);
                Assert.Same(eventArgs, e);
                callCount++;
            };
            int invalidatedCallCount = 0;
            InvalidateEventHandler invalidatedHandler = (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            EventHandler styleChangedHandler = (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            EventHandler createdHandler = (sender, e) => createdCallCount++;

            // Call with handler.
            control.RightToLeftLayoutChanged += handler;
            control.Invalidated += invalidatedHandler;
            control.StyleChanged += styleChangedHandler;
            control.HandleCreated += createdHandler;
            control.OnRightToLeftLayoutChanged(eventArgs);
            Assert.Equal(1, callCount);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(1, createdCallCount);

            // Remove handler.
            control.RightToLeftLayoutChanged -= handler;
            control.Invalidated -= invalidatedHandler;
            control.StyleChanged -= styleChangedHandler;
            control.HandleCreated -= createdHandler;
            control.OnRightToLeftLayoutChanged(eventArgs);
            Assert.True(control.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(1, createdCallCount);
        }

        [Fact]
        public void MonthCalendar_OnRightToLeftLayoutChanged_InvokeInDisposing_DoesNotCallRightToLeftLayoutChanged()
        {
            using var control = new SubMonthCalendar
            {
                RightToLeft = RightToLeft.Yes
            };
            Assert.NotEqual(IntPtr.Zero, control.Handle);

            int callCount = 0;
            control.RightToLeftLayoutChanged += (sender, e) => callCount++;
            int createdCallCount = 0;
            control.HandleCreated += (sender, e) => createdCallCount++;

            int disposedCallCount = 0;
            control.Disposed += (sender, e) =>
            {
                control.OnRightToLeftLayoutChanged(EventArgs.Empty);
                Assert.Equal(0, callCount);
                Assert.Equal(0, createdCallCount);
                disposedCallCount++;
            };

            control.Dispose();
            Assert.Equal(1, disposedCallCount);
        }

        [Fact]
        public void MonthCalendar_RecreateHandle_InvokeWithHandle_Success()
        {
            using var control = new SubMonthCalendar();
            IntPtr handle1 = control.Handle;
            Assert.NotEqual(IntPtr.Zero, handle1);
            Assert.True(control.IsHandleCreated);

            control.RecreateHandle();
            IntPtr handle2 = control.Handle;
            Assert.NotEqual(IntPtr.Zero, handle2);
            Assert.NotEqual(handle1, handle2);
            Assert.True(control.IsHandleCreated);

            // Invoke again.
            control.RecreateHandle();
            IntPtr handle3 = control.Handle;
            Assert.NotEqual(IntPtr.Zero, handle3);
            Assert.NotEqual(handle2, handle3);
            Assert.True(control.IsHandleCreated);
        }

        [Fact]
        public void MonthCalendar_RecreateHandle_InvokeWithoutHandle_Nop()
        {
            using var control = new SubMonthCalendar();
            control.RecreateHandle();
            Assert.False(control.IsHandleCreated);

            // Invoke again.
            control.RecreateHandle();
            Assert.False(control.IsHandleCreated);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(0, 0)]
        [InlineData(-1, -2)]
        public void MonthControl_RescaleConstantsForDpi_Invoke_Nop(int deviceDpiOld, int deviceDpiNew)
        {
            using var control = new SubMonthCalendar();
            control.RescaleConstantsForDpi(deviceDpiOld, deviceDpiNew);
        }

        public static IEnumerable<object[]> SetDate_TestData()
        {
            yield return new object[] { DateTime.MinValue };
            yield return new object[] { new DateTime(1753, 1, 1).AddTicks(-1) };
            yield return new object[] { new DateTime(1753, 1, 1) };
            yield return new object[] { new DateTime(2019, 9, 1) };
            yield return new object[] { new DateTime(2019, 9, 1).AddHours(1) };
            yield return new object[] { DateTime.Now.Date };
            yield return new object[] { DateTime.Now.Date.AddHours(1) };
            yield return new object[] { new DateTime(9998, 12, 31) };
            yield return new object[] { new DateTime(9998, 12, 31).AddTicks(1) };
            yield return new object[] { DateTime.MaxValue };
        }

        [Theory]
        [MemberData(nameof(SetDate_TestData))]
        public void MonthCalendar_SetDate_Invoke_GetReturnsExpected(DateTime date)
        {
            using var calendar = new MonthCalendar();
            calendar.SetDate(date);
            Assert.Equal(date.Date, calendar.SelectionRange.Start);
            Assert.Equal(date.Date, calendar.SelectionRange.End);
            Assert.Equal(date, calendar.SelectionStart);
            Assert.Equal(date, calendar.SelectionEnd);
            Assert.False(calendar.IsHandleCreated);

            // Call again.
            calendar.SetDate(date);
            Assert.Equal(date.Date, calendar.SelectionRange.Start);
            Assert.Equal(date.Date, calendar.SelectionRange.End);
            Assert.Equal(date, calendar.SelectionStart);
            Assert.Equal(date, calendar.SelectionEnd);
            Assert.False(calendar.IsHandleCreated);
        }

        [Theory]
        [MemberData(nameof(SetDate_TestData))]
        public void MonthCalendar_SetDate_InvokeWithHandle_GetReturnsExpected(DateTime date)
        {
            using var calendar = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, calendar.Handle);
            int invalidatedCallCount = 0;
            calendar.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            calendar.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            calendar.HandleCreated += (sender, e) => createdCallCount++;

            calendar.SetDate(date);
            Assert.Equal(date.Date, calendar.SelectionRange.Start);
            Assert.Equal(date.Date, calendar.SelectionRange.End);
            Assert.Equal(date, calendar.SelectionStart);
            Assert.Equal(date, calendar.SelectionEnd);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Call again.
            calendar.SetDate(date);
            Assert.Equal(date.Date, calendar.SelectionRange.Start);
            Assert.Equal(date.Date, calendar.SelectionRange.End);
            Assert.Equal(date, calendar.SelectionStart);
            Assert.Equal(date, calendar.SelectionEnd);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Fact]
        public void MonthCalendar_SetDate_DateLessThanMinDate_ThrowsArgumentOutOfRangeException()
        {
            using var calendar = new MonthCalendar();
            calendar.SetDate(calendar.MinDate.AddTicks(-1));
            Assert.Equal(calendar.MinDate.AddTicks(-1), calendar.SelectionStart);
            Assert.Equal(calendar.MinDate.AddTicks(-1), calendar.SelectionEnd);

            calendar.MinDate = new DateTime(2019, 10, 3);
            Assert.Throws<ArgumentOutOfRangeException>("date", () => calendar.SetDate(calendar.MinDate.AddTicks(-1)));
        }

        [Fact]
        public void MonthCalendar_SetDate_DateGreaterThanMaxDate_ThrowsArgumentOutOfRangeException()
        {
            using var calendar = new MonthCalendar();
            calendar.SetDate(calendar.MaxDate.AddTicks(1));
            Assert.Equal(calendar.MaxDate.AddTicks(1), calendar.SelectionStart);
            Assert.Equal(calendar.MaxDate.AddTicks(1), calendar.SelectionEnd);

            calendar.MaxDate = new DateTime(2019, 9, 3);
            Assert.Throws<ArgumentOutOfRangeException>("date", () => calendar.SetDate(calendar.MaxDate.AddDays(1)));
        }

        public static IEnumerable<object[]> SetSelectionRange_TestData()
        {
            yield return new object[] { DateTime.MinValue, DateTime.MinValue, DateTime.MinValue, DateTime.MinValue };
            yield return new object[] { new DateTime(1753, 1, 1).AddTicks(-1), new DateTime(1753, 1, 1).AddTicks(-1), new DateTime(1753, 1, 1).AddTicks(-1), new DateTime(1753, 1, 1).AddTicks(-1) };
            yield return new object[] { new DateTime(1753, 1, 1), new DateTime(1753, 1, 1), new DateTime(1753, 1, 1), new DateTime(1753, 1, 1) };
            yield return new object[] { new DateTime(1753, 1, 1), new DateTime(1753, 1, 2), new DateTime(1753, 1, 1), new DateTime(1753, 1, 2) };

            yield return new object[] { new DateTime(2019, 9, 1), new DateTime(2019, 9, 1), new DateTime(2019, 9, 1), new DateTime(2019, 9, 1) };
            yield return new object[] { new DateTime(2019, 9, 1), new DateTime(2019, 9, 2), new DateTime(2019, 9, 1), new DateTime(2019, 9, 2) };
            yield return new object[] { new DateTime(2019, 9, 1).AddHours(1), new DateTime(2019, 9, 2).AddHours(1), new DateTime(2019, 9, 1).AddHours(1), new DateTime(2019, 9, 2).AddHours(1) };
            yield return new object[] { new DateTime(2019, 9, 2), new DateTime(2019, 9, 1), new DateTime(2019, 9, 2), new DateTime(2019, 9, 2) };
            yield return new object[] { new DateTime(2019, 9, 1), new DateTime(2019, 9, 7), new DateTime(2019, 9, 1), new DateTime(2019, 9, 7) };
            yield return new object[] { new DateTime(2019, 9, 1), new DateTime(2019, 9, 8), new DateTime(2019, 9, 1), new DateTime(2019, 9, 7) };

            yield return new object[] { DateTime.Now.Date, DateTime.Now.Date, DateTime.Now.Date, DateTime.Now.Date };
            yield return new object[] { DateTime.Now.Date, DateTime.Now.Date.AddDays(1), DateTime.Now.Date, DateTime.Now.Date.AddDays(1) };
            yield return new object[] { DateTime.Now.Date.AddHours(1), DateTime.Now.Date.AddHours(1), DateTime.Now.Date.AddHours(1), DateTime.Now.Date.AddHours(1) };
            yield return new object[] { DateTime.Now.Date.AddDays(1), DateTime.Now.Date, DateTime.Now.Date.AddDays(1), DateTime.Now.Date.AddDays(1) };
            yield return new object[] { DateTime.Now.Date, DateTime.Now.Date.AddDays(6), DateTime.Now.Date, DateTime.Now.Date.AddDays(6) };
            yield return new object[] { DateTime.Now.Date, DateTime.Now.Date.AddDays(7), DateTime.Now.Date.AddDays(1), DateTime.Now.Date.AddDays(7) };

            yield return new object[] { new DateTime(9998, 12, 30), new DateTime(9998, 12, 31), new DateTime(9998, 12, 30), new DateTime(9998, 12, 31) };
            yield return new object[] { new DateTime(9998, 12, 31), new DateTime(9998, 12, 31), new DateTime(9998, 12, 31), new DateTime(9998, 12, 31) };
            yield return new object[] { new DateTime(9998, 12, 31).AddTicks(1), new DateTime(9998, 12, 31).AddTicks(1), new DateTime(9998, 12, 31).AddTicks(1), new DateTime(9998, 12, 31).AddTicks(1) };
            yield return new object[] { DateTime.MaxValue, DateTime.MaxValue, DateTime.MaxValue, DateTime.MaxValue };
        }

        [Theory]
        [MemberData(nameof(SetSelectionRange_TestData))]
        public void MonthCalendar_SetSelectionRange_Invoke_GetReturnsExpected(DateTime date1, DateTime date2, DateTime expectedSelectionStart, DateTime expectedSelectionEnd)
        {
            using var calendar = new MonthCalendar();
            calendar.SetSelectionRange(date1, date2);
            Assert.Equal(expectedSelectionStart.Date, calendar.SelectionRange.Start);
            Assert.Equal(expectedSelectionEnd.Date, calendar.SelectionRange.End);
            Assert.Equal(expectedSelectionStart, calendar.SelectionStart);
            Assert.Equal(expectedSelectionEnd, calendar.SelectionEnd);
            Assert.False(calendar.IsHandleCreated);

            // Call again.
            calendar.SetSelectionRange(expectedSelectionStart, expectedSelectionEnd);
            Assert.Equal(expectedSelectionStart.Date, calendar.SelectionRange.Start);
            Assert.Equal(expectedSelectionEnd.Date, calendar.SelectionRange.End);
            Assert.Equal(expectedSelectionStart, calendar.SelectionStart);
            Assert.Equal(expectedSelectionEnd, calendar.SelectionEnd);
            Assert.False(calendar.IsHandleCreated);
        }

        [Theory]
        [MemberData(nameof(SetSelectionRange_TestData))]
        public void MonthCalendar_SetSelectionRange_InvokeWithHandle_GetReturnsExpected(DateTime date1, DateTime date2, DateTime expectedSelectionStart, DateTime expectedSelectionEnd)
        {
            using var calendar = new MonthCalendar();
            Assert.NotEqual(IntPtr.Zero, calendar.Handle);
            int invalidatedCallCount = 0;
            calendar.Invalidated += (sender, e) => invalidatedCallCount++;
            int styleChangedCallCount = 0;
            calendar.StyleChanged += (sender, e) => styleChangedCallCount++;
            int createdCallCount = 0;
            calendar.HandleCreated += (sender, e) => createdCallCount++;

            calendar.SetSelectionRange(date1, date2);
            Assert.Equal(expectedSelectionStart.Date, calendar.SelectionRange.Start);
            Assert.Equal(expectedSelectionEnd.Date, calendar.SelectionRange.End);
            Assert.Equal(expectedSelectionStart, calendar.SelectionStart);
            Assert.Equal(expectedSelectionEnd, calendar.SelectionEnd);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);

            // Call again.
            calendar.SetSelectionRange(expectedSelectionStart, expectedSelectionEnd);
            Assert.Equal(expectedSelectionStart.Date, calendar.SelectionRange.Start);
            Assert.Equal(expectedSelectionEnd.Date, calendar.SelectionRange.End);
            Assert.Equal(expectedSelectionStart, calendar.SelectionStart);
            Assert.Equal(expectedSelectionEnd, calendar.SelectionEnd);
            Assert.True(calendar.IsHandleCreated);
            Assert.Equal(0, invalidatedCallCount);
            Assert.Equal(0, styleChangedCallCount);
            Assert.Equal(0, createdCallCount);
        }

        [Fact]
        public void MonthCalendar_SetSelectionRange_DateLessThanMinDate_ThrowsArgumentOutOfRangeException()
        {
            using var calendar = new MonthCalendar();
            calendar.SetSelectionRange(calendar.MinDate.AddTicks(-1), calendar.MinDate);
            Assert.Equal(calendar.MinDate.AddTicks(-1), calendar.SelectionStart);
            Assert.Equal(calendar.MinDate, calendar.SelectionEnd);

            calendar.SetSelectionRange(calendar.MinDate, calendar.MinDate.AddTicks(-1));
            Assert.Equal(calendar.MinDate, calendar.SelectionStart);
            Assert.Equal(calendar.MinDate, calendar.SelectionEnd);

            calendar.MinDate = new DateTime(2019, 10, 3);
            Assert.Throws<ArgumentOutOfRangeException>("date1", () => calendar.SetSelectionRange(calendar.MinDate.AddTicks(-1), calendar.MinDate));
            Assert.Throws<ArgumentOutOfRangeException>("date2", () => calendar.SetSelectionRange(calendar.MinDate, calendar.MinDate.AddTicks(-1)));
        }

        [Fact]
        public void MonthCalendar_SetSelectionRange_DateGreaterThanMaxDate_ThrowsArgumentOutOfRangeException()
        {
            using var calendar = new MonthCalendar();
            calendar.SetSelectionRange(calendar.MaxDate.AddTicks(1), calendar.MaxDate);
            Assert.Equal(calendar.MaxDate.AddTicks(1), calendar.SelectionStart);
            Assert.Equal(calendar.MaxDate.AddTicks(1), calendar.SelectionEnd);

            calendar.SetSelectionRange(calendar.MaxDate, calendar.MaxDate.AddTicks(1));
            Assert.Equal(calendar.MaxDate, calendar.SelectionStart);
            Assert.Equal(calendar.MaxDate.AddTicks(1), calendar.SelectionEnd);

            calendar.MaxDate = new DateTime(2019, 9, 3);
            Assert.Throws<ArgumentOutOfRangeException>("date1", () => calendar.SetSelectionRange(calendar.MaxDate.AddDays(1), calendar.MaxDate));
            Assert.Throws<ArgumentOutOfRangeException>("date2", () => calendar.SetSelectionRange(calendar.MaxDate, calendar.MaxDate.AddDays(1)));
        }

        private class SubMonthCalendar : MonthCalendar
        {
            public new bool CanEnableIme => base.CanEnableIme;

            public new bool CanRaiseEvents => base.CanRaiseEvents;

            public new CreateParams CreateParams => base.CreateParams;

            public new Cursor DefaultCursor => base.DefaultCursor;

            public new ImeMode DefaultImeMode => base.DefaultImeMode;

            public new Padding DefaultMargin => base.DefaultMargin;

            public new Size DefaultMaximumSize => base.DefaultMaximumSize;

            public new Size DefaultMinimumSize => base.DefaultMinimumSize;

            public new Padding DefaultPadding => base.DefaultPadding;

            public new Size DefaultSize => base.DefaultSize;

            public new bool DesignMode => base.DesignMode;

            public new bool DoubleBuffered
            {
                get => base.DoubleBuffered;
                set => base.DoubleBuffered = value;
            }

            public new EventHandlerList Events => base.Events;

            public new int FontHeight
            {
                get => base.FontHeight;
                set => base.FontHeight = value;
            }

            public new ImeMode ImeModeBase
            {
                get => base.ImeModeBase;
                set => base.ImeModeBase = value;
            }

            public new bool ResizeRedraw
            {
                get => base.ResizeRedraw;
                set => base.ResizeRedraw = value;
            }

            public new AccessibleObject CreateAccessibilityInstance() => base.CreateAccessibilityInstance();

            public new void CreateHandle() => base.CreateHandle();

            public new bool GetStyle(ControlStyles flag) => base.GetStyle(flag);

            public new void OnBackColorChanged(EventArgs e) => base.OnBackColorChanged(e);

            public new void OnClick(EventArgs e) => base.OnClick(e);

            public new void OnDateChanged(DateRangeEventArgs e) => base.OnDateChanged(e);

            public new void OnDateSelected(DateRangeEventArgs e) => base.OnDateSelected(e);

            public new void OnDoubleClick(EventArgs e) => base.OnDoubleClick(e);

            public new void OnFontChanged(EventArgs e) => base.OnFontChanged(e);

            public new void OnForeColorChanged(EventArgs e) => base.OnForeColorChanged(e);

            public new void OnHandleCreated(EventArgs e) => base.OnHandleCreated(e);

            public new void OnHandleDestroyed(EventArgs e) => base.OnHandleDestroyed(e);

            public new void OnMouseClick(MouseEventArgs e) => base.OnMouseClick(e);

            public new void OnMouseDoubleClick(MouseEventArgs e) => base.OnMouseDoubleClick(e);

            public new void OnPaint(PaintEventArgs e) => base.OnPaint(e);

            public new void OnRightToLeftLayoutChanged(EventArgs e) => base.OnRightToLeftLayoutChanged(e);

            public new void RecreateHandle() => base.RecreateHandle();

            public new void RescaleConstantsForDpi(int deviceDpiOld, int deviceDpiNew) => base.RescaleConstantsForDpi(deviceDpiOld, deviceDpiNew);

            public new void SetStyle(ControlStyles flag, bool value) => base.SetStyle(flag, value);
        }
    }
}
