using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Drawing.Drawing2D;
using DevExpress.XtraCharts;
//using Microsoft.VisualBasic.PowerPacks;
//using C1.Win.C1FlexGrid;

namespace Smart_FTY
{
    public partial class FRM_RUB_TEMP_TRACKING : SampleFrm1
    {

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_RUB_TEMP_TRACKING));
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange25 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange26 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange27 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange28 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange29 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange30 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange31 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange32 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange33 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange34 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange35 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange36 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange13 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange14 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange15 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange37 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange38 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange39 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange16 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange17 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange18 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange40 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange41 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange42 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraCharts.XYDiagram xyDiagram5 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView5 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraCharts.XYDiagram xyDiagram6 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series6 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView6 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange19 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange20 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange21 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange43 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange44 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange45 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange22 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange23 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange24 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange46 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange47 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraGauges.Core.Model.LinearScaleRange linearScaleRange48 = new DevExpress.XtraGauges.Core.Model.LinearScaleRange();
            DevExpress.XtraCharts.XYDiagram xyDiagram7 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series7 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView7 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraCharts.XYDiagram xyDiagram8 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series8 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView8 = new DevExpress.XtraCharts.SplineSeriesView();
            this.pn_body = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnEVA = new Smart_FTY.A1Panel();
            this.lblEVA = new System.Windows.Forms.Label();
            this.pnRubber = new Smart_FTY.A1Panel();
            this.lblRubber = new System.Windows.Forms.Label();
            this.btnEva = new System.Windows.Forms.Button();
            this.btnRubber = new System.Windows.Forms.Button();
            this.tpn_show = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxEx2 = new Smart_FTY.ClassLib.GroupBoxEx();
            this.gaugeControl5 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRoll1Line2MCMax = new System.Windows.Forms.Label();
            this.lblRoll1Line2MCMin = new System.Windows.Forms.Label();
            this.lblRoll1Line2MC = new System.Windows.Forms.Label();
            this.lnRollMC12 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge();
            this.linearScaleBackgroundLayerComponent3 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent();
            this.linearScaleComponent3 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent();
            this.linearScaleLevelComponent3 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent();
            this.gaugeControl8 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRoll1Line1MCMax = new System.Windows.Forms.Label();
            this.lblRoll1Line1MCMin = new System.Windows.Forms.Label();
            this.lblRoll1Line1MC = new System.Windows.Forms.Label();
            this.lnRollMC11 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge();
            this.linearScaleBackgroundLayerComponent4 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent();
            this.linearScaleComponent4 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent();
            this.linearScaleLevelComponent4 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent();
            this.groupBoxEx3 = new Smart_FTY.ClassLib.GroupBoxEx();
            this.gaugeControl6 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.lblRoll2Line2MCMax = new System.Windows.Forms.Label();
            this.lblRoll2Line2MCMin = new System.Windows.Forms.Label();
            this.lblRoll2Line2MC = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lnRollMC22 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge();
            this.linearScaleBackgroundLayerComponent5 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent();
            this.linearScaleComponent5 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent();
            this.linearScaleLevelComponent5 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent();
            this.gaugeControl7 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.lblRoll2Line1MCMax = new System.Windows.Forms.Label();
            this.lblRoll2Line1MCMin = new System.Windows.Forms.Label();
            this.lblRoll2Line1MC = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lnRollMC21 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge();
            this.linearScaleBackgroundLayerComponent6 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent();
            this.linearScaleComponent6 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent();
            this.linearScaleLevelComponent6 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent();
            this.groupBoxEx1 = new Smart_FTY.ClassLib.GroupBoxEx();
            this.gaugeControl4 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.lblBanburyLine2MatMax = new System.Windows.Forms.Label();
            this.lblBanburyLine2MatMin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBanburyLine2Mat = new System.Windows.Forms.Label();
            this.cirBanburyMat2 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleBackgroundLayerComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleNeedleComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleSpindleCapComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent();
            this.gaugeControl3 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBanburyLine2MCMax = new System.Windows.Forms.Label();
            this.lblBanburyLine2MCMin = new System.Windows.Forms.Label();
            this.lblBanburyLine2MC = new System.Windows.Forms.Label();
            this.lnBanburyMC2 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge();
            this.linearScaleBackgroundLayerComponent2 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent();
            this.linearScaleComponent2 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent();
            this.linearScaleLevelComponent2 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent();
            this.gaugeControl2 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBanburyLine1MatMax = new System.Windows.Forms.Label();
            this.lblBanburyLine1MatMin = new System.Windows.Forms.Label();
            this.lblBanburyLine1Mat = new System.Windows.Forms.Label();
            this.cirBanburyMat1 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleNeedleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleSpindleCapComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent();
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.lblBanburyLine1MCMax = new System.Windows.Forms.Label();
            this.lblBanburyLine1MCMin = new System.Windows.Forms.Label();
            this.lblBanburyLine1MC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lnBanburyMC1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge();
            this.linearScaleBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent();
            this.linearScaleLevelComponent1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent();
            this.lnScaleCompBanburyMC1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent();
            this.groupBoxEx6 = new Smart_FTY.ClassLib.GroupBoxEx();
            this.chartCalendar = new DevExpress.XtraCharts.ChartControl();
            this.chartRoll2 = new DevExpress.XtraCharts.ChartControl();
            this.groupBoxEx4 = new Smart_FTY.ClassLib.GroupBoxEx();
            this.gaugeControl9 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.label27 = new System.Windows.Forms.Label();
            this.lblCalendarLine2MatMax = new System.Windows.Forms.Label();
            this.lblCalendarLine2MatMin = new System.Windows.Forms.Label();
            this.lblCalendarLine2Mat = new System.Windows.Forms.Label();
            this.cirCalendarMat2 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleBackgroundLayerComponent3 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleComponent3 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleNeedleComponent3 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleSpindleCapComponent3 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent();
            this.gaugeControl10 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.lblCalendarLine2MCMax = new System.Windows.Forms.Label();
            this.lblCalendarLine2MCMin = new System.Windows.Forms.Label();
            this.lblCalendarLine2MC = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lnCalendarMC2 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge();
            this.linearScaleBackgroundLayerComponent7 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent();
            this.linearScaleComponent7 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent();
            this.linearScaleLevelComponent7 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent();
            this.gaugeControl11 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.label23 = new System.Windows.Forms.Label();
            this.lblCalendarLine1MatMax = new System.Windows.Forms.Label();
            this.lblCalendarLine1MatMin = new System.Windows.Forms.Label();
            this.lblCalendarLine1Mat = new System.Windows.Forms.Label();
            this.cirCalendarMat1 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleBackgroundLayerComponent4 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleComponent4 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleNeedleComponent4 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleSpindleCapComponent4 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent();
            this.gaugeControl12 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.lblCalendarLine1MCMax = new System.Windows.Forms.Label();
            this.lblCalendarLine1MCMin = new System.Windows.Forms.Label();
            this.lblCalendarLine1MC = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lnCalendarMC1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge();
            this.linearScaleBackgroundLayerComponent8 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent();
            this.linearScaleComponent8 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent();
            this.linearScaleLevelComponent8 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent();
            this.groupBoxEx5 = new Smart_FTY.ClassLib.GroupBoxEx();
            this.chartRoll1 = new DevExpress.XtraCharts.ChartControl();
            this.chartBanbury = new DevExpress.XtraCharts.ChartControl();
            this.axGrid = new AxFPUSpreadADO.AxfpSpread();
            this.tmrLoad = new System.Windows.Forms.Timer(this.components);
            this.pnHeader.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.pn_body.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnEVA.SuspendLayout();
            this.pnRubber.SuspendLayout();
            this.tpn_show.SuspendLayout();
            this.groupBoxEx2.SuspendLayout();
            this.gaugeControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lnRollMC12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleBackgroundLayerComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleLevelComponent3)).BeginInit();
            this.gaugeControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lnRollMC11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleBackgroundLayerComponent4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleLevelComponent4)).BeginInit();
            this.groupBoxEx3.SuspendLayout();
            this.gaugeControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lnRollMC22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleBackgroundLayerComponent5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleLevelComponent5)).BeginInit();
            this.gaugeControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lnRollMC21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleBackgroundLayerComponent6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleLevelComponent6)).BeginInit();
            this.groupBoxEx1.SuspendLayout();
            this.gaugeControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cirBanburyMat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent2)).BeginInit();
            this.gaugeControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lnBanburyMC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleBackgroundLayerComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleLevelComponent2)).BeginInit();
            this.gaugeControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cirBanburyMat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent1)).BeginInit();
            this.gaugeControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lnBanburyMC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleLevelComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnScaleCompBanburyMC1)).BeginInit();
            this.groupBoxEx6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCalendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRoll2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView6)).BeginInit();
            this.groupBoxEx4.SuspendLayout();
            this.gaugeControl9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cirCalendarMat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent3)).BeginInit();
            this.gaugeControl10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lnCalendarMC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleBackgroundLayerComponent7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleLevelComponent7)).BeginInit();
            this.gaugeControl11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cirCalendarMat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent4)).BeginInit();
            this.gaugeControl12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lnCalendarMC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleBackgroundLayerComponent8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleLevelComponent8)).BeginInit();
            this.groupBoxEx5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRoll1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBanbury)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.Text = "2018-10-06\n13:32:21";
            // 
            // cmdYear
            // 
            this.cmdYear.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdYear.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdYear.Appearance.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdYear.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.cmdYear.Appearance.Options.UseBackColor = true;
            this.cmdYear.Appearance.Options.UseFont = true;
            this.cmdYear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdYear.ImageOptions.Image")));
            // 
            // cmdMonth
            // 
            this.cmdMonth.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdMonth.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdMonth.Appearance.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold);
            this.cmdMonth.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.cmdMonth.Appearance.Options.UseBackColor = true;
            this.cmdMonth.Appearance.Options.UseFont = true;
            this.cmdMonth.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdMonth.ImageOptions.Image")));
            // 
            // cmdDay
            // 
            this.cmdDay.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdDay.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdDay.Appearance.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold);
            this.cmdDay.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.cmdDay.Appearance.Options.UseBackColor = true;
            this.cmdDay.Appearance.Options.UseFont = true;
            this.cmdDay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdDay.ImageOptions.Image")));
            // 
            // cmdBack
            // 
            this.cmdBack.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.cmdBack.FlatAppearance.BorderSize = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Calibri", 50F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Appearance.Options.UseBackColor = true;
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Appearance.Options.UseForeColor = true;
            this.lblTitle.Location = new System.Drawing.Point(0, 14);
            // 
            // lblShift
            // 
            this.lblShift.Size = new System.Drawing.Size(413, 53);
            this.lblShift.Text = "Shift 1 (06:00 ~ 14:00)";
            // 
            // pn_body
            // 
            this.pn_body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_body.BackColor = System.Drawing.Color.Transparent;
            this.pn_body.Controls.Add(this.panel2);
            this.pn_body.Controls.Add(this.btnEva);
            this.pn_body.Controls.Add(this.btnRubber);
            this.pn_body.Controls.Add(this.tpn_show);
            this.pn_body.Location = new System.Drawing.Point(0, 108);
            this.pn_body.Name = "pn_body";
            this.pn_body.Size = new System.Drawing.Size(1916, 945);
            this.pn_body.TabIndex = 48;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnEVA);
            this.panel2.Controls.Add(this.pnRubber);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1916, 57);
            this.panel2.TabIndex = 74;
            // 
            // pnEVA
            // 
            this.pnEVA.AccessibleDescription = "";
            this.pnEVA.AccessibleName = "";
            this.pnEVA.BorderColor = System.Drawing.Color.Empty;
            this.pnEVA.BorderWidth = 2;
            this.pnEVA.Controls.Add(this.lblEVA);
            this.pnEVA.GradientEndColor = System.Drawing.Color.White;
            this.pnEVA.GradientStartColor = System.Drawing.Color.White;
            this.pnEVA.Image = null;
            this.pnEVA.ImageLocation = new System.Drawing.Point(4, 4);
            this.pnEVA.Location = new System.Drawing.Point(160, 5);
            this.pnEVA.Name = "pnEVA";
            this.pnEVA.RoundCornerRadius = 20;
            this.pnEVA.ShadowOffSet = 3;
            this.pnEVA.Size = new System.Drawing.Size(153, 49);
            this.pnEVA.TabIndex = 0;
            // 
            // lblEVA
            // 
            this.lblEVA.BackColor = System.Drawing.Color.Transparent;
            this.lblEVA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEVA.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEVA.Location = new System.Drawing.Point(0, 0);
            this.lblEVA.Name = "lblEVA";
            this.lblEVA.Size = new System.Drawing.Size(153, 49);
            this.lblEVA.TabIndex = 1;
            this.lblEVA.Text = "EVA";
            this.lblEVA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEVA.Click += new System.EventHandler(this.lblEVA_Click);
            // 
            // pnRubber
            // 
            this.pnRubber.AccessibleDescription = "";
            this.pnRubber.AccessibleName = "";
            this.pnRubber.BorderColor = System.Drawing.Color.Empty;
            this.pnRubber.BorderWidth = 2;
            this.pnRubber.Controls.Add(this.lblRubber);
            this.pnRubber.GradientEndColor = System.Drawing.Color.Gray;
            this.pnRubber.GradientStartColor = System.Drawing.Color.White;
            this.pnRubber.Image = null;
            this.pnRubber.ImageLocation = new System.Drawing.Point(4, 4);
            this.pnRubber.Location = new System.Drawing.Point(3, 5);
            this.pnRubber.Name = "pnRubber";
            this.pnRubber.RoundCornerRadius = 20;
            this.pnRubber.ShadowOffSet = 3;
            this.pnRubber.Size = new System.Drawing.Size(153, 49);
            this.pnRubber.TabIndex = 0;
            // 
            // lblRubber
            // 
            this.lblRubber.BackColor = System.Drawing.Color.Transparent;
            this.lblRubber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRubber.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubber.Location = new System.Drawing.Point(0, 0);
            this.lblRubber.Name = "lblRubber";
            this.lblRubber.Size = new System.Drawing.Size(153, 49);
            this.lblRubber.TabIndex = 0;
            this.lblRubber.Text = "Rubber";
            this.lblRubber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEva
            // 
            this.btnEva.BackColor = System.Drawing.Color.White;
            this.btnEva.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEva.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold);
            this.btnEva.ForeColor = System.Drawing.Color.Black;
            this.btnEva.Location = new System.Drawing.Point(148, 3);
            this.btnEva.Name = "btnEva";
            this.btnEva.Size = new System.Drawing.Size(150, 54);
            this.btnEva.TabIndex = 5;
            this.btnEva.Text = "EVA";
            this.btnEva.UseVisualStyleBackColor = false;
            this.btnEva.Visible = false;
            this.btnEva.Click += new System.EventHandler(this.btnEva_Click);
            // 
            // btnRubber
            // 
            this.btnRubber.BackColor = System.Drawing.Color.Gray;
            this.btnRubber.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRubber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRubber.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold);
            this.btnRubber.ForeColor = System.Drawing.Color.White;
            this.btnRubber.Location = new System.Drawing.Point(-2, 3);
            this.btnRubber.Name = "btnRubber";
            this.btnRubber.Size = new System.Drawing.Size(150, 54);
            this.btnRubber.TabIndex = 4;
            this.btnRubber.Text = "Rubber";
            this.btnRubber.UseVisualStyleBackColor = false;
            this.btnRubber.Visible = false;
            // 
            // tpn_show
            // 
            this.tpn_show.ColumnCount = 3;
            this.tpn_show.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpn_show.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpn_show.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 662F));
            this.tpn_show.Controls.Add(this.groupBoxEx2, 1, 0);
            this.tpn_show.Controls.Add(this.groupBoxEx3, 1, 1);
            this.tpn_show.Controls.Add(this.groupBoxEx1, 0, 0);
            this.tpn_show.Controls.Add(this.groupBoxEx6, 2, 1);
            this.tpn_show.Controls.Add(this.groupBoxEx4, 0, 1);
            this.tpn_show.Controls.Add(this.groupBoxEx5, 2, 0);
            this.tpn_show.Location = new System.Drawing.Point(0, 64);
            this.tpn_show.Name = "tpn_show";
            this.tpn_show.RowCount = 2;
            this.tpn_show.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpn_show.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpn_show.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpn_show.Size = new System.Drawing.Size(1916, 889);
            this.tpn_show.TabIndex = 3;
            // 
            // groupBoxEx2
            // 
            this.groupBoxEx2.BackgroundPanelImage = null;
            this.groupBoxEx2.Controls.Add(this.gaugeControl5);
            this.groupBoxEx2.Controls.Add(this.gaugeControl8);
            this.groupBoxEx2.DrawGroupBorder = true;
            this.groupBoxEx2.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEx2.ForeColor = System.Drawing.Color.White;
            this.groupBoxEx2.GroupBorderColor = System.Drawing.Color.White;
            this.groupBoxEx2.GroupPanelColor = System.Drawing.SystemColors.Control;
            this.groupBoxEx2.GroupPanelShape = Smart_FTY.ClassLib.GroupBoxEx.PanelType.Rounded;
            this.groupBoxEx2.GroupPanelWith = 1F;
            this.groupBoxEx2.Location = new System.Drawing.Point(630, 3);
            this.groupBoxEx2.Name = "groupBoxEx2";
            this.groupBoxEx2.Size = new System.Drawing.Size(621, 438);
            this.groupBoxEx2.TabIndex = 53;
            this.groupBoxEx2.TabStop = false;
            this.groupBoxEx2.Text = "ROLL - No 1";
            this.groupBoxEx2.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBoxEx2.TextBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBoxEx2.TextBorderWith = 1F;
            // 
            // gaugeControl5
            // 
            this.gaugeControl5.AutoLayout = false;
            this.gaugeControl5.Controls.Add(this.label5);
            this.gaugeControl5.Controls.Add(this.lblRoll1Line2MCMax);
            this.gaugeControl5.Controls.Add(this.lblRoll1Line2MCMin);
            this.gaugeControl5.Controls.Add(this.lblRoll1Line2MC);
            this.gaugeControl5.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.lnRollMC12});
            this.gaugeControl5.Location = new System.Drawing.Point(322, 55);
            this.gaugeControl5.Name = "gaugeControl5";
            this.gaugeControl5.Size = new System.Drawing.Size(287, 380);
            this.gaugeControl5.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Machine 2";
            // 
            // lblRoll1Line2MCMax
            // 
            this.lblRoll1Line2MCMax.AutoSize = true;
            this.lblRoll1Line2MCMax.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll1Line2MCMax.ForeColor = System.Drawing.Color.Black;
            this.lblRoll1Line2MCMax.Location = new System.Drawing.Point(163, 115);
            this.lblRoll1Line2MCMax.Name = "lblRoll1Line2MCMax";
            this.lblRoll1Line2MCMax.Size = new System.Drawing.Size(83, 23);
            this.lblRoll1Line2MCMax.TabIndex = 10;
            this.lblRoll1Line2MCMax.Text = "Min :  0°C";
            // 
            // lblRoll1Line2MCMin
            // 
            this.lblRoll1Line2MCMin.AutoSize = true;
            this.lblRoll1Line2MCMin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll1Line2MCMin.ForeColor = System.Drawing.Color.Black;
            this.lblRoll1Line2MCMin.Location = new System.Drawing.Point(163, 68);
            this.lblRoll1Line2MCMin.Name = "lblRoll1Line2MCMin";
            this.lblRoll1Line2MCMin.Size = new System.Drawing.Size(83, 23);
            this.lblRoll1Line2MCMin.TabIndex = 9;
            this.lblRoll1Line2MCMin.Text = "Min :  0°C";
            // 
            // lblRoll1Line2MC
            // 
            this.lblRoll1Line2MC.AutoSize = true;
            this.lblRoll1Line2MC.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll1Line2MC.ForeColor = System.Drawing.Color.Black;
            this.lblRoll1Line2MC.Location = new System.Drawing.Point(163, 173);
            this.lblRoll1Line2MC.Name = "lblRoll1Line2MC";
            this.lblRoll1Line2MC.Size = new System.Drawing.Size(86, 23);
            this.lblRoll1Line2MC.TabIndex = 8;
            this.lblRoll1Line2MC.Text = "M/C :  0°C";
            // 
            // lnRollMC12
            // 
            this.lnRollMC12.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent[] {
            this.linearScaleBackgroundLayerComponent3});
            this.lnRollMC12.Bounds = new System.Drawing.Rectangle(3, 2, 155, 401);
            this.lnRollMC12.Levels.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent[] {
            this.linearScaleLevelComponent3});
            this.lnRollMC12.Name = "lnRollMC12";
            this.lnRollMC12.OptionsToolTip.TooltipTitleFormat = "{0}";
            this.lnRollMC12.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent[] {
            this.linearScaleComponent3});
            // 
            // linearScaleBackgroundLayerComponent3
            // 
            this.linearScaleBackgroundLayerComponent3.LinearScale = this.linearScaleComponent3;
            this.linearScaleBackgroundLayerComponent3.Name = "bg1";
            this.linearScaleBackgroundLayerComponent3.ScaleStartPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.85F);
            this.linearScaleBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style25;
            this.linearScaleBackgroundLayerComponent3.ZOrder = 1000;
            // 
            // linearScaleComponent3
            // 
            this.linearScaleComponent3.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent3.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent3.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent3.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent3.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 8F);
            this.linearScaleComponent3.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent3.EndPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 38F);
            this.linearScaleComponent3.MajorTickCount = 6;
            this.linearScaleComponent3.MajorTickmark.FormatString = "{0:F0}";
            this.linearScaleComponent3.MajorTickmark.ShapeOffset = -25F;
            this.linearScaleComponent3.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style25_1;
            this.linearScaleComponent3.MajorTickmark.TextOffset = -35F;
            this.linearScaleComponent3.MaxValue = 100F;
            this.linearScaleComponent3.MinorTickCount = 4;
            this.linearScaleComponent3.MinorTickmark.ShapeOffset = -22F;
            this.linearScaleComponent3.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style25_2;
            this.linearScaleComponent3.Name = "scale1";
            linearScaleRange25.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
            linearScaleRange25.EndThickness = 3F;
            linearScaleRange25.EndValue = 33F;
            linearScaleRange25.Name = "Range0";
            linearScaleRange25.ShapeOffset = -12F;
            linearScaleRange25.StartThickness = 3F;
            linearScaleRange26.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00C000");
            linearScaleRange26.EndThickness = 3F;
            linearScaleRange26.EndValue = 66F;
            linearScaleRange26.Name = "Range1";
            linearScaleRange26.ShapeOffset = -12F;
            linearScaleRange26.StartThickness = 3F;
            linearScaleRange26.StartValue = 33F;
            linearScaleRange27.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
            linearScaleRange27.EndThickness = 3F;
            linearScaleRange27.EndValue = 100F;
            linearScaleRange27.Name = "Range2";
            linearScaleRange27.ShapeOffset = -12F;
            linearScaleRange27.StartThickness = 3F;
            linearScaleRange27.StartValue = 66F;
            this.linearScaleComponent3.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            linearScaleRange25,
            linearScaleRange26,
            linearScaleRange27});
            this.linearScaleComponent3.StartPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 212F);
            this.linearScaleComponent3.Value = 50F;
            // 
            // linearScaleLevelComponent3
            // 
            this.linearScaleLevelComponent3.LinearScale = this.linearScaleComponent3;
            this.linearScaleLevelComponent3.Name = "level1";
            this.linearScaleLevelComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style25;
            this.linearScaleLevelComponent3.ZOrder = -50;
            // 
            // gaugeControl8
            // 
            this.gaugeControl8.AutoLayout = false;
            this.gaugeControl8.Controls.Add(this.label9);
            this.gaugeControl8.Controls.Add(this.lblRoll1Line1MCMax);
            this.gaugeControl8.Controls.Add(this.lblRoll1Line1MCMin);
            this.gaugeControl8.Controls.Add(this.lblRoll1Line1MC);
            this.gaugeControl8.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.lnRollMC11});
            this.gaugeControl8.Location = new System.Drawing.Point(9, 55);
            this.gaugeControl8.Name = "gaugeControl8";
            this.gaugeControl8.Size = new System.Drawing.Size(287, 380);
            this.gaugeControl8.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Teal;
            this.label9.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(167, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 29);
            this.label9.TabIndex = 11;
            this.label9.Text = "Machine 1";
            // 
            // lblRoll1Line1MCMax
            // 
            this.lblRoll1Line1MCMax.AutoSize = true;
            this.lblRoll1Line1MCMax.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll1Line1MCMax.ForeColor = System.Drawing.Color.Black;
            this.lblRoll1Line1MCMax.Location = new System.Drawing.Point(164, 115);
            this.lblRoll1Line1MCMax.Name = "lblRoll1Line1MCMax";
            this.lblRoll1Line1MCMax.Size = new System.Drawing.Size(86, 23);
            this.lblRoll1Line1MCMax.TabIndex = 10;
            this.lblRoll1Line1MCMax.Text = "Max :  0°C";
            // 
            // lblRoll1Line1MCMin
            // 
            this.lblRoll1Line1MCMin.AutoSize = true;
            this.lblRoll1Line1MCMin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll1Line1MCMin.ForeColor = System.Drawing.Color.Black;
            this.lblRoll1Line1MCMin.Location = new System.Drawing.Point(163, 68);
            this.lblRoll1Line1MCMin.Name = "lblRoll1Line1MCMin";
            this.lblRoll1Line1MCMin.Size = new System.Drawing.Size(83, 23);
            this.lblRoll1Line1MCMin.TabIndex = 9;
            this.lblRoll1Line1MCMin.Text = "Min :  0°C";
            // 
            // lblRoll1Line1MC
            // 
            this.lblRoll1Line1MC.AutoSize = true;
            this.lblRoll1Line1MC.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll1Line1MC.ForeColor = System.Drawing.Color.Black;
            this.lblRoll1Line1MC.Location = new System.Drawing.Point(164, 173);
            this.lblRoll1Line1MC.Name = "lblRoll1Line1MC";
            this.lblRoll1Line1MC.Size = new System.Drawing.Size(86, 23);
            this.lblRoll1Line1MC.TabIndex = 8;
            this.lblRoll1Line1MC.Text = "M/C :  0°C";
            // 
            // lnRollMC11
            // 
            this.lnRollMC11.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent[] {
            this.linearScaleBackgroundLayerComponent4});
            this.lnRollMC11.Bounds = new System.Drawing.Rectangle(5, 5, 154, 394);
            this.lnRollMC11.Levels.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent[] {
            this.linearScaleLevelComponent4});
            this.lnRollMC11.Name = "lnRollMC11";
            this.lnRollMC11.OptionsToolTip.TooltipTitleFormat = "{0}";
            this.lnRollMC11.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent[] {
            this.linearScaleComponent4});
            // 
            // linearScaleBackgroundLayerComponent4
            // 
            this.linearScaleBackgroundLayerComponent4.LinearScale = this.linearScaleComponent4;
            this.linearScaleBackgroundLayerComponent4.Name = "bg1";
            this.linearScaleBackgroundLayerComponent4.ScaleStartPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.85F);
            this.linearScaleBackgroundLayerComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style25;
            this.linearScaleBackgroundLayerComponent4.ZOrder = 1000;
            // 
            // linearScaleComponent4
            // 
            this.linearScaleComponent4.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent4.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent4.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent4.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent4.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 8F);
            this.linearScaleComponent4.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent4.EndPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 38F);
            this.linearScaleComponent4.MajorTickCount = 6;
            this.linearScaleComponent4.MajorTickmark.FormatString = "{0:F0}";
            this.linearScaleComponent4.MajorTickmark.ShapeOffset = -25F;
            this.linearScaleComponent4.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style25_1;
            this.linearScaleComponent4.MajorTickmark.TextOffset = -35F;
            this.linearScaleComponent4.MaxValue = 100F;
            this.linearScaleComponent4.MinorTickCount = 4;
            this.linearScaleComponent4.MinorTickmark.ShapeOffset = -22F;
            this.linearScaleComponent4.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style25_2;
            this.linearScaleComponent4.Name = "scale1";
            linearScaleRange28.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
            linearScaleRange28.EndThickness = 3F;
            linearScaleRange28.EndValue = 33F;
            linearScaleRange28.Name = "Range0";
            linearScaleRange28.ShapeOffset = -12F;
            linearScaleRange28.StartThickness = 3F;
            linearScaleRange29.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00C000");
            linearScaleRange29.EndThickness = 3F;
            linearScaleRange29.EndValue = 66F;
            linearScaleRange29.Name = "Range1";
            linearScaleRange29.ShapeOffset = -12F;
            linearScaleRange29.StartThickness = 3F;
            linearScaleRange29.StartValue = 33F;
            linearScaleRange30.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
            linearScaleRange30.EndThickness = 3F;
            linearScaleRange30.EndValue = 100F;
            linearScaleRange30.Name = "Range2";
            linearScaleRange30.ShapeOffset = -12F;
            linearScaleRange30.StartThickness = 3F;
            linearScaleRange30.StartValue = 66F;
            this.linearScaleComponent4.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            linearScaleRange28,
            linearScaleRange29,
            linearScaleRange30});
            this.linearScaleComponent4.StartPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 212F);
            this.linearScaleComponent4.Value = 50F;
            // 
            // linearScaleLevelComponent4
            // 
            this.linearScaleLevelComponent4.LinearScale = this.linearScaleComponent4;
            this.linearScaleLevelComponent4.Name = "level1";
            this.linearScaleLevelComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style25;
            this.linearScaleLevelComponent4.ZOrder = -50;
            // 
            // groupBoxEx3
            // 
            this.groupBoxEx3.BackgroundPanelImage = null;
            this.groupBoxEx3.Controls.Add(this.gaugeControl6);
            this.groupBoxEx3.Controls.Add(this.gaugeControl7);
            this.groupBoxEx3.DrawGroupBorder = true;
            this.groupBoxEx3.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEx3.ForeColor = System.Drawing.Color.White;
            this.groupBoxEx3.GroupBorderColor = System.Drawing.Color.White;
            this.groupBoxEx3.GroupPanelColor = System.Drawing.SystemColors.Control;
            this.groupBoxEx3.GroupPanelShape = Smart_FTY.ClassLib.GroupBoxEx.PanelType.Rounded;
            this.groupBoxEx3.GroupPanelWith = 1F;
            this.groupBoxEx3.Location = new System.Drawing.Point(630, 447);
            this.groupBoxEx3.Name = "groupBoxEx3";
            this.groupBoxEx3.Size = new System.Drawing.Size(621, 439);
            this.groupBoxEx3.TabIndex = 54;
            this.groupBoxEx3.TabStop = false;
            this.groupBoxEx3.Text = "ROLL - No 2";
            this.groupBoxEx3.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBoxEx3.TextBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBoxEx3.TextBorderWith = 1F;
            // 
            // gaugeControl6
            // 
            this.gaugeControl6.AutoLayout = false;
            this.gaugeControl6.Controls.Add(this.lblRoll2Line2MCMax);
            this.gaugeControl6.Controls.Add(this.lblRoll2Line2MCMin);
            this.gaugeControl6.Controls.Add(this.lblRoll2Line2MC);
            this.gaugeControl6.Controls.Add(this.label14);
            this.gaugeControl6.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.lnRollMC22});
            this.gaugeControl6.Location = new System.Drawing.Point(315, 55);
            this.gaugeControl6.Name = "gaugeControl6";
            this.gaugeControl6.Size = new System.Drawing.Size(296, 378);
            this.gaugeControl6.TabIndex = 1;
            // 
            // lblRoll2Line2MCMax
            // 
            this.lblRoll2Line2MCMax.AutoSize = true;
            this.lblRoll2Line2MCMax.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll2Line2MCMax.ForeColor = System.Drawing.Color.Black;
            this.lblRoll2Line2MCMax.Location = new System.Drawing.Point(163, 116);
            this.lblRoll2Line2MCMax.Name = "lblRoll2Line2MCMax";
            this.lblRoll2Line2MCMax.Size = new System.Drawing.Size(86, 23);
            this.lblRoll2Line2MCMax.TabIndex = 9;
            this.lblRoll2Line2MCMax.Text = "Max :  0°C";
            // 
            // lblRoll2Line2MCMin
            // 
            this.lblRoll2Line2MCMin.AutoSize = true;
            this.lblRoll2Line2MCMin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll2Line2MCMin.ForeColor = System.Drawing.Color.Black;
            this.lblRoll2Line2MCMin.Location = new System.Drawing.Point(163, 66);
            this.lblRoll2Line2MCMin.Name = "lblRoll2Line2MCMin";
            this.lblRoll2Line2MCMin.Size = new System.Drawing.Size(83, 23);
            this.lblRoll2Line2MCMin.TabIndex = 8;
            this.lblRoll2Line2MCMin.Text = "Min :  0°C";
            // 
            // lblRoll2Line2MC
            // 
            this.lblRoll2Line2MC.AutoSize = true;
            this.lblRoll2Line2MC.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll2Line2MC.ForeColor = System.Drawing.Color.Black;
            this.lblRoll2Line2MC.Location = new System.Drawing.Point(162, 174);
            this.lblRoll2Line2MC.Name = "lblRoll2Line2MC";
            this.lblRoll2Line2MC.Size = new System.Drawing.Size(86, 23);
            this.lblRoll2Line2MC.TabIndex = 7;
            this.lblRoll2Line2MC.Text = "M/C :  0°C";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Teal;
            this.label14.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(175, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 29);
            this.label14.TabIndex = 6;
            this.label14.Text = "Machine 2";
            // 
            // lnRollMC22
            // 
            this.lnRollMC22.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent[] {
            this.linearScaleBackgroundLayerComponent5});
            this.lnRollMC22.Bounds = new System.Drawing.Rectangle(6, 6, 151, 395);
            this.lnRollMC22.Levels.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent[] {
            this.linearScaleLevelComponent5});
            this.lnRollMC22.Name = "lnRollMC22";
            this.lnRollMC22.OptionsToolTip.TooltipTitleFormat = "{0}";
            this.lnRollMC22.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent[] {
            this.linearScaleComponent5});
            // 
            // linearScaleBackgroundLayerComponent5
            // 
            this.linearScaleBackgroundLayerComponent5.LinearScale = this.linearScaleComponent5;
            this.linearScaleBackgroundLayerComponent5.Name = "bg1";
            this.linearScaleBackgroundLayerComponent5.ScaleStartPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.85F);
            this.linearScaleBackgroundLayerComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style25;
            this.linearScaleBackgroundLayerComponent5.ZOrder = 1000;
            // 
            // linearScaleComponent5
            // 
            this.linearScaleComponent5.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent5.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent5.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent5.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent5.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 8F);
            this.linearScaleComponent5.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent5.EndPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 38F);
            this.linearScaleComponent5.MajorTickCount = 6;
            this.linearScaleComponent5.MajorTickmark.FormatString = "{0:F0}";
            this.linearScaleComponent5.MajorTickmark.ShapeOffset = -25F;
            this.linearScaleComponent5.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style25_1;
            this.linearScaleComponent5.MajorTickmark.TextOffset = -35F;
            this.linearScaleComponent5.MaxValue = 100F;
            this.linearScaleComponent5.MinorTickCount = 4;
            this.linearScaleComponent5.MinorTickmark.ShapeOffset = -22F;
            this.linearScaleComponent5.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style25_2;
            this.linearScaleComponent5.Name = "scale1";
            linearScaleRange31.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
            linearScaleRange31.EndThickness = 3F;
            linearScaleRange31.EndValue = 33F;
            linearScaleRange31.Name = "Range0";
            linearScaleRange31.ShapeOffset = -12F;
            linearScaleRange31.StartThickness = 3F;
            linearScaleRange32.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00C000");
            linearScaleRange32.EndThickness = 3F;
            linearScaleRange32.EndValue = 66F;
            linearScaleRange32.Name = "Range1";
            linearScaleRange32.ShapeOffset = -12F;
            linearScaleRange32.StartThickness = 3F;
            linearScaleRange32.StartValue = 33F;
            linearScaleRange33.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
            linearScaleRange33.EndThickness = 3F;
            linearScaleRange33.EndValue = 100F;
            linearScaleRange33.Name = "Range2";
            linearScaleRange33.ShapeOffset = -12F;
            linearScaleRange33.StartThickness = 3F;
            linearScaleRange33.StartValue = 66F;
            this.linearScaleComponent5.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            linearScaleRange31,
            linearScaleRange32,
            linearScaleRange33});
            this.linearScaleComponent5.StartPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 212F);
            this.linearScaleComponent5.Value = 50F;
            // 
            // linearScaleLevelComponent5
            // 
            this.linearScaleLevelComponent5.LinearScale = this.linearScaleComponent5;
            this.linearScaleLevelComponent5.Name = "level1";
            this.linearScaleLevelComponent5.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style25;
            this.linearScaleLevelComponent5.ZOrder = -50;
            // 
            // gaugeControl7
            // 
            this.gaugeControl7.AutoLayout = false;
            this.gaugeControl7.Controls.Add(this.lblRoll2Line1MCMax);
            this.gaugeControl7.Controls.Add(this.lblRoll2Line1MCMin);
            this.gaugeControl7.Controls.Add(this.lblRoll2Line1MC);
            this.gaugeControl7.Controls.Add(this.label10);
            this.gaugeControl7.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.lnRollMC21});
            this.gaugeControl7.Location = new System.Drawing.Point(9, 55);
            this.gaugeControl7.Name = "gaugeControl7";
            this.gaugeControl7.Size = new System.Drawing.Size(287, 377);
            this.gaugeControl7.TabIndex = 0;
            // 
            // lblRoll2Line1MCMax
            // 
            this.lblRoll2Line1MCMax.AutoSize = true;
            this.lblRoll2Line1MCMax.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll2Line1MCMax.ForeColor = System.Drawing.Color.Black;
            this.lblRoll2Line1MCMax.Location = new System.Drawing.Point(161, 114);
            this.lblRoll2Line1MCMax.Name = "lblRoll2Line1MCMax";
            this.lblRoll2Line1MCMax.Size = new System.Drawing.Size(86, 23);
            this.lblRoll2Line1MCMax.TabIndex = 9;
            this.lblRoll2Line1MCMax.Text = "Max :  0°C";
            // 
            // lblRoll2Line1MCMin
            // 
            this.lblRoll2Line1MCMin.AutoSize = true;
            this.lblRoll2Line1MCMin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll2Line1MCMin.ForeColor = System.Drawing.Color.Black;
            this.lblRoll2Line1MCMin.Location = new System.Drawing.Point(161, 64);
            this.lblRoll2Line1MCMin.Name = "lblRoll2Line1MCMin";
            this.lblRoll2Line1MCMin.Size = new System.Drawing.Size(83, 23);
            this.lblRoll2Line1MCMin.TabIndex = 8;
            this.lblRoll2Line1MCMin.Text = "Min :  0°C";
            // 
            // lblRoll2Line1MC
            // 
            this.lblRoll2Line1MC.AutoSize = true;
            this.lblRoll2Line1MC.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll2Line1MC.ForeColor = System.Drawing.Color.Black;
            this.lblRoll2Line1MC.Location = new System.Drawing.Point(160, 172);
            this.lblRoll2Line1MC.Name = "lblRoll2Line1MC";
            this.lblRoll2Line1MC.Size = new System.Drawing.Size(86, 23);
            this.lblRoll2Line1MC.TabIndex = 7;
            this.lblRoll2Line1MC.Text = "M/C :  0°C";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Teal;
            this.label10.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(168, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 29);
            this.label10.TabIndex = 6;
            this.label10.Text = "Machine 1";
            // 
            // lnRollMC21
            // 
            this.lnRollMC21.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent[] {
            this.linearScaleBackgroundLayerComponent6});
            this.lnRollMC21.Bounds = new System.Drawing.Rectangle(1, 22, 149, 338);
            this.lnRollMC21.Levels.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent[] {
            this.linearScaleLevelComponent6});
            this.lnRollMC21.Name = "lnRollMC21";
            this.lnRollMC21.OptionsToolTip.TooltipTitleFormat = "{0}";
            this.lnRollMC21.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent[] {
            this.linearScaleComponent6});
            // 
            // linearScaleBackgroundLayerComponent6
            // 
            this.linearScaleBackgroundLayerComponent6.LinearScale = this.linearScaleComponent6;
            this.linearScaleBackgroundLayerComponent6.Name = "bg1";
            this.linearScaleBackgroundLayerComponent6.ScaleStartPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.85F);
            this.linearScaleBackgroundLayerComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style25;
            this.linearScaleBackgroundLayerComponent6.ZOrder = 1000;
            // 
            // linearScaleComponent6
            // 
            this.linearScaleComponent6.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent6.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent6.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent6.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent6.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 8F);
            this.linearScaleComponent6.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent6.EndPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 38F);
            this.linearScaleComponent6.MajorTickCount = 6;
            this.linearScaleComponent6.MajorTickmark.FormatString = "{0:F0}";
            this.linearScaleComponent6.MajorTickmark.ShapeOffset = -25F;
            this.linearScaleComponent6.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style25_1;
            this.linearScaleComponent6.MajorTickmark.TextOffset = -35F;
            this.linearScaleComponent6.MaxValue = 100F;
            this.linearScaleComponent6.MinorTickCount = 4;
            this.linearScaleComponent6.MinorTickmark.ShapeOffset = -22F;
            this.linearScaleComponent6.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style25_2;
            this.linearScaleComponent6.Name = "scale1";
            linearScaleRange34.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
            linearScaleRange34.EndThickness = 3F;
            linearScaleRange34.EndValue = 33F;
            linearScaleRange34.Name = "Range0";
            linearScaleRange34.ShapeOffset = -12F;
            linearScaleRange34.StartThickness = 3F;
            linearScaleRange35.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00C000");
            linearScaleRange35.EndThickness = 3F;
            linearScaleRange35.EndValue = 66F;
            linearScaleRange35.Name = "Range1";
            linearScaleRange35.ShapeOffset = -12F;
            linearScaleRange35.StartThickness = 3F;
            linearScaleRange35.StartValue = 33F;
            linearScaleRange36.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
            linearScaleRange36.EndThickness = 3F;
            linearScaleRange36.EndValue = 100F;
            linearScaleRange36.Name = "Range2";
            linearScaleRange36.ShapeOffset = -12F;
            linearScaleRange36.StartThickness = 3F;
            linearScaleRange36.StartValue = 66F;
            this.linearScaleComponent6.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            linearScaleRange34,
            linearScaleRange35,
            linearScaleRange36});
            this.linearScaleComponent6.StartPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 212F);
            this.linearScaleComponent6.Value = 50F;
            // 
            // linearScaleLevelComponent6
            // 
            this.linearScaleLevelComponent6.LinearScale = this.linearScaleComponent6;
            this.linearScaleLevelComponent6.Name = "level1";
            this.linearScaleLevelComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style25;
            this.linearScaleLevelComponent6.ZOrder = -50;
            // 
            // groupBoxEx1
            // 
            this.groupBoxEx1.BackgroundPanelImage = null;
            this.groupBoxEx1.Controls.Add(this.gaugeControl4);
            this.groupBoxEx1.Controls.Add(this.gaugeControl3);
            this.groupBoxEx1.Controls.Add(this.gaugeControl2);
            this.groupBoxEx1.Controls.Add(this.gaugeControl1);
            this.groupBoxEx1.DrawGroupBorder = true;
            this.groupBoxEx1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEx1.ForeColor = System.Drawing.Color.White;
            this.groupBoxEx1.GroupBorderColor = System.Drawing.Color.Black;
            this.groupBoxEx1.GroupPanelColor = System.Drawing.SystemColors.Control;
            this.groupBoxEx1.GroupPanelShape = Smart_FTY.ClassLib.GroupBoxEx.PanelType.Rounded;
            this.groupBoxEx1.GroupPanelWith = 1F;
            this.groupBoxEx1.Location = new System.Drawing.Point(3, 3);
            this.groupBoxEx1.Name = "groupBoxEx1";
            this.groupBoxEx1.Size = new System.Drawing.Size(621, 438);
            this.groupBoxEx1.TabIndex = 0;
            this.groupBoxEx1.TabStop = false;
            this.groupBoxEx1.Text = "BANBURY";
            this.groupBoxEx1.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBoxEx1.TextBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBoxEx1.TextBorderWith = 1F;
            // 
            // gaugeControl4
            // 
            this.gaugeControl4.AutoLayout = false;
            this.gaugeControl4.Controls.Add(this.lblBanburyLine2MatMax);
            this.gaugeControl4.Controls.Add(this.lblBanburyLine2MatMin);
            this.gaugeControl4.Controls.Add(this.label4);
            this.gaugeControl4.Controls.Add(this.lblBanburyLine2Mat);
            this.gaugeControl4.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.cirBanburyMat2});
            this.gaugeControl4.Location = new System.Drawing.Point(315, 280);
            this.gaugeControl4.Name = "gaugeControl4";
            this.gaugeControl4.Size = new System.Drawing.Size(296, 157);
            this.gaugeControl4.TabIndex = 53;
            // 
            // lblBanburyLine2MatMax
            // 
            this.lblBanburyLine2MatMax.AutoSize = true;
            this.lblBanburyLine2MatMax.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanburyLine2MatMax.ForeColor = System.Drawing.Color.Black;
            this.lblBanburyLine2MatMax.Location = new System.Drawing.Point(171, 86);
            this.lblBanburyLine2MatMax.Name = "lblBanburyLine2MatMax";
            this.lblBanburyLine2MatMax.Size = new System.Drawing.Size(86, 23);
            this.lblBanburyLine2MatMax.TabIndex = 12;
            this.lblBanburyLine2MatMax.Text = "Max :  0°C";
            // 
            // lblBanburyLine2MatMin
            // 
            this.lblBanburyLine2MatMin.AutoSize = true;
            this.lblBanburyLine2MatMin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanburyLine2MatMin.ForeColor = System.Drawing.Color.Black;
            this.lblBanburyLine2MatMin.Location = new System.Drawing.Point(170, 47);
            this.lblBanburyLine2MatMin.Name = "lblBanburyLine2MatMin";
            this.lblBanburyLine2MatMin.Size = new System.Drawing.Size(83, 23);
            this.lblBanburyLine2MatMin.TabIndex = 11;
            this.lblBanburyLine2MatMin.Text = "Min :  0°C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Material 2";
            // 
            // lblBanburyLine2Mat
            // 
            this.lblBanburyLine2Mat.AutoSize = true;
            this.lblBanburyLine2Mat.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanburyLine2Mat.ForeColor = System.Drawing.Color.Black;
            this.lblBanburyLine2Mat.Location = new System.Drawing.Point(173, 125);
            this.lblBanburyLine2Mat.Name = "lblBanburyLine2Mat";
            this.lblBanburyLine2Mat.Size = new System.Drawing.Size(79, 23);
            this.lblBanburyLine2Mat.TabIndex = 5;
            this.lblBanburyLine2Mat.Text = "Mtl :  0°C";
            // 
            // cirBanburyMat2
            // 
            this.cirBanburyMat2.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent2});
            this.cirBanburyMat2.Bounds = new System.Drawing.Rectangle(5, 8, 158, 144);
            this.cirBanburyMat2.Name = "cirBanburyMat2";
            this.cirBanburyMat2.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent2});
            this.cirBanburyMat2.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent2});
            this.cirBanburyMat2.SpindleCaps.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent[] {
            this.arcScaleSpindleCapComponent2});
            // 
            // arcScaleBackgroundLayerComponent2
            // 
            this.arcScaleBackgroundLayerComponent2.ArcScale = this.arcScaleComponent2;
            this.arcScaleBackgroundLayerComponent2.Name = "bg";
            this.arcScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style16;
            this.arcScaleBackgroundLayerComponent2.ZOrder = 1000;
            // 
            // arcScaleComponent2
            // 
            this.arcScaleComponent2.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent2.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent2.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent2.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent2.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.arcScaleComponent2.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A");
            this.arcScaleComponent2.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F);
            this.arcScaleComponent2.EndAngle = 60F;
            this.arcScaleComponent2.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent2.MajorTickmark.ShapeOffset = -14F;
            this.arcScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1;
            this.arcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent2.MaxValue = 100F;
            this.arcScaleComponent2.MinorTickCount = 4;
            this.arcScaleComponent2.MinorTickmark.ShapeOffset = -7F;
            this.arcScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2;
            this.arcScaleComponent2.Name = "scale1";
            arcScaleRange13.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
            arcScaleRange13.EndThickness = 14F;
            arcScaleRange13.EndValue = 33F;
            arcScaleRange13.Name = "Range0";
            arcScaleRange13.ShapeOffset = 0F;
            arcScaleRange13.StartThickness = 14F;
            arcScaleRange14.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00C000");
            arcScaleRange14.EndThickness = 14F;
            arcScaleRange14.EndValue = 66F;
            arcScaleRange14.Name = "Range1";
            arcScaleRange14.ShapeOffset = 0F;
            arcScaleRange14.StartThickness = 14F;
            arcScaleRange14.StartValue = 33F;
            arcScaleRange15.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
            arcScaleRange15.EndThickness = 14F;
            arcScaleRange15.EndValue = 100F;
            arcScaleRange15.Name = "Range2";
            arcScaleRange15.ShapeOffset = 0F;
            arcScaleRange15.StartThickness = 14F;
            arcScaleRange15.StartValue = 66F;
            this.arcScaleComponent2.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            arcScaleRange13,
            arcScaleRange14,
            arcScaleRange15});
            this.arcScaleComponent2.StartAngle = -240F;
            this.arcScaleComponent2.Value = 80F;
            // 
            // arcScaleNeedleComponent2
            // 
            this.arcScaleNeedleComponent2.ArcScale = this.arcScaleComponent2;
            this.arcScaleNeedleComponent2.EndOffset = 5F;
            this.arcScaleNeedleComponent2.Name = "needle";
            this.arcScaleNeedleComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style16;
            this.arcScaleNeedleComponent2.ZOrder = -50;
            // 
            // arcScaleSpindleCapComponent2
            // 
            this.arcScaleSpindleCapComponent2.ArcScale = this.arcScaleComponent2;
            this.arcScaleSpindleCapComponent2.Name = "cGauge1_SpindleCap1";
            this.arcScaleSpindleCapComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style16;
            this.arcScaleSpindleCapComponent2.Size = new System.Drawing.SizeF(25F, 25F);
            this.arcScaleSpindleCapComponent2.ZOrder = -100;
            // 
            // gaugeControl3
            // 
            this.gaugeControl3.AutoLayout = false;
            this.gaugeControl3.Controls.Add(this.label2);
            this.gaugeControl3.Controls.Add(this.lblBanburyLine2MCMax);
            this.gaugeControl3.Controls.Add(this.lblBanburyLine2MCMin);
            this.gaugeControl3.Controls.Add(this.lblBanburyLine2MC);
            this.gaugeControl3.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.lnBanburyMC2});
            this.gaugeControl3.Location = new System.Drawing.Point(315, 55);
            this.gaugeControl3.Name = "gaugeControl3";
            this.gaugeControl3.Size = new System.Drawing.Size(296, 211);
            this.gaugeControl3.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Machine 2";
            // 
            // lblBanburyLine2MCMax
            // 
            this.lblBanburyLine2MCMax.AutoSize = true;
            this.lblBanburyLine2MCMax.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanburyLine2MCMax.ForeColor = System.Drawing.Color.Black;
            this.lblBanburyLine2MCMax.Location = new System.Drawing.Point(171, 115);
            this.lblBanburyLine2MCMax.Name = "lblBanburyLine2MCMax";
            this.lblBanburyLine2MCMax.Size = new System.Drawing.Size(86, 23);
            this.lblBanburyLine2MCMax.TabIndex = 6;
            this.lblBanburyLine2MCMax.Text = "Max :  0°C";
            // 
            // lblBanburyLine2MCMin
            // 
            this.lblBanburyLine2MCMin.AutoSize = true;
            this.lblBanburyLine2MCMin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanburyLine2MCMin.ForeColor = System.Drawing.Color.Black;
            this.lblBanburyLine2MCMin.Location = new System.Drawing.Point(170, 68);
            this.lblBanburyLine2MCMin.Name = "lblBanburyLine2MCMin";
            this.lblBanburyLine2MCMin.Size = new System.Drawing.Size(83, 23);
            this.lblBanburyLine2MCMin.TabIndex = 5;
            this.lblBanburyLine2MCMin.Text = "Min :  0°C";
            // 
            // lblBanburyLine2MC
            // 
            this.lblBanburyLine2MC.AutoSize = true;
            this.lblBanburyLine2MC.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanburyLine2MC.ForeColor = System.Drawing.Color.Black;
            this.lblBanburyLine2MC.Location = new System.Drawing.Point(170, 173);
            this.lblBanburyLine2MC.Name = "lblBanburyLine2MC";
            this.lblBanburyLine2MC.Size = new System.Drawing.Size(82, 23);
            this.lblBanburyLine2MC.TabIndex = 4;
            this.lblBanburyLine2MC.Text = "M/C : 0°C";
            // 
            // lnBanburyMC2
            // 
            this.lnBanburyMC2.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent[] {
            this.linearScaleBackgroundLayerComponent2});
            this.lnBanburyMC2.Bounds = new System.Drawing.Rectangle(6, 5, 158, 199);
            this.lnBanburyMC2.Levels.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent[] {
            this.linearScaleLevelComponent2});
            this.lnBanburyMC2.Name = "lnBanburyMC2";
            this.lnBanburyMC2.OptionsToolTip.TooltipTitleFormat = "{0}";
            this.lnBanburyMC2.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent[] {
            this.linearScaleComponent2});
            // 
            // linearScaleBackgroundLayerComponent2
            // 
            this.linearScaleBackgroundLayerComponent2.LinearScale = this.linearScaleComponent2;
            this.linearScaleBackgroundLayerComponent2.Name = "bg1";
            this.linearScaleBackgroundLayerComponent2.ScaleStartPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.85F);
            this.linearScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style25;
            this.linearScaleBackgroundLayerComponent2.ZOrder = 1000;
            // 
            // linearScaleComponent2
            // 
            this.linearScaleComponent2.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent2.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent2.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent2.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent2.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 8F);
            this.linearScaleComponent2.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent2.EndPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 38F);
            this.linearScaleComponent2.MajorTickCount = 6;
            this.linearScaleComponent2.MajorTickmark.FormatString = "{0:F0}";
            this.linearScaleComponent2.MajorTickmark.ShapeOffset = -25F;
            this.linearScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style25_1;
            this.linearScaleComponent2.MajorTickmark.TextOffset = -35F;
            this.linearScaleComponent2.MaxValue = 100F;
            this.linearScaleComponent2.MinorTickCount = 4;
            this.linearScaleComponent2.MinorTickmark.ShapeOffset = -22F;
            this.linearScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style25_2;
            this.linearScaleComponent2.Name = "scale1";
            linearScaleRange37.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
            linearScaleRange37.EndThickness = 3F;
            linearScaleRange37.EndValue = 33F;
            linearScaleRange37.Name = "Range0";
            linearScaleRange37.ShapeOffset = -12F;
            linearScaleRange37.StartThickness = 3F;
            linearScaleRange38.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00C000");
            linearScaleRange38.EndThickness = 3F;
            linearScaleRange38.EndValue = 66F;
            linearScaleRange38.Name = "Range1";
            linearScaleRange38.ShapeOffset = -12F;
            linearScaleRange38.StartThickness = 3F;
            linearScaleRange38.StartValue = 33F;
            linearScaleRange39.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
            linearScaleRange39.EndThickness = 3F;
            linearScaleRange39.EndValue = 100F;
            linearScaleRange39.Name = "Range2";
            linearScaleRange39.ShapeOffset = -12F;
            linearScaleRange39.StartThickness = 3F;
            linearScaleRange39.StartValue = 66F;
            this.linearScaleComponent2.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            linearScaleRange37,
            linearScaleRange38,
            linearScaleRange39});
            this.linearScaleComponent2.StartPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 212F);
            this.linearScaleComponent2.Value = 50F;
            // 
            // linearScaleLevelComponent2
            // 
            this.linearScaleLevelComponent2.LinearScale = this.linearScaleComponent2;
            this.linearScaleLevelComponent2.Name = "level1";
            this.linearScaleLevelComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style25;
            this.linearScaleLevelComponent2.ZOrder = -50;
            // 
            // gaugeControl2
            // 
            this.gaugeControl2.AutoLayout = false;
            this.gaugeControl2.Controls.Add(this.label3);
            this.gaugeControl2.Controls.Add(this.lblBanburyLine1MatMax);
            this.gaugeControl2.Controls.Add(this.lblBanburyLine1MatMin);
            this.gaugeControl2.Controls.Add(this.lblBanburyLine1Mat);
            this.gaugeControl2.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.cirBanburyMat1});
            this.gaugeControl2.Location = new System.Drawing.Point(9, 280);
            this.gaugeControl2.Name = "gaugeControl2";
            this.gaugeControl2.Size = new System.Drawing.Size(287, 157);
            this.gaugeControl2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Material 1";
            // 
            // lblBanburyLine1MatMax
            // 
            this.lblBanburyLine1MatMax.AutoSize = true;
            this.lblBanburyLine1MatMax.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanburyLine1MatMax.ForeColor = System.Drawing.Color.Black;
            this.lblBanburyLine1MatMax.Location = new System.Drawing.Point(167, 86);
            this.lblBanburyLine1MatMax.Name = "lblBanburyLine1MatMax";
            this.lblBanburyLine1MatMax.Size = new System.Drawing.Size(86, 23);
            this.lblBanburyLine1MatMax.TabIndex = 8;
            this.lblBanburyLine1MatMax.Text = "Max :  0°C";
            // 
            // lblBanburyLine1MatMin
            // 
            this.lblBanburyLine1MatMin.AutoSize = true;
            this.lblBanburyLine1MatMin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanburyLine1MatMin.ForeColor = System.Drawing.Color.Black;
            this.lblBanburyLine1MatMin.Location = new System.Drawing.Point(166, 51);
            this.lblBanburyLine1MatMin.Name = "lblBanburyLine1MatMin";
            this.lblBanburyLine1MatMin.Size = new System.Drawing.Size(83, 23);
            this.lblBanburyLine1MatMin.TabIndex = 7;
            this.lblBanburyLine1MatMin.Text = "Min :  0°C";
            // 
            // lblBanburyLine1Mat
            // 
            this.lblBanburyLine1Mat.AutoSize = true;
            this.lblBanburyLine1Mat.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanburyLine1Mat.ForeColor = System.Drawing.Color.Black;
            this.lblBanburyLine1Mat.Location = new System.Drawing.Point(167, 125);
            this.lblBanburyLine1Mat.Name = "lblBanburyLine1Mat";
            this.lblBanburyLine1Mat.Size = new System.Drawing.Size(79, 23);
            this.lblBanburyLine1Mat.TabIndex = 5;
            this.lblBanburyLine1Mat.Text = "Mtl :  0°C";
            // 
            // cirBanburyMat1
            // 
            this.cirBanburyMat1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent1});
            this.cirBanburyMat1.Bounds = new System.Drawing.Rectangle(5, 8, 150, 137);
            this.cirBanburyMat1.Name = "cirBanburyMat1";
            this.cirBanburyMat1.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent1});
            this.cirBanburyMat1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent1});
            this.cirBanburyMat1.SpindleCaps.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent[] {
            this.arcScaleSpindleCapComponent1});
            // 
            // arcScaleBackgroundLayerComponent1
            // 
            this.arcScaleBackgroundLayerComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleBackgroundLayerComponent1.Name = "bg";
            this.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style16;
            this.arcScaleBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // arcScaleComponent1
            // 
            this.arcScaleComponent1.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent1.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.arcScaleComponent1.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A");
            this.arcScaleComponent1.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F);
            this.arcScaleComponent1.EndAngle = 60F;
            this.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent1.MajorTickmark.ShapeOffset = -14F;
            this.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1;
            this.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent1.MaxValue = 100F;
            this.arcScaleComponent1.MinorTickCount = 4;
            this.arcScaleComponent1.MinorTickmark.ShapeOffset = -7F;
            this.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2;
            this.arcScaleComponent1.Name = "scale1";
            arcScaleRange16.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
            arcScaleRange16.EndThickness = 14F;
            arcScaleRange16.EndValue = 33F;
            arcScaleRange16.Name = "Range0";
            arcScaleRange16.ShapeOffset = 0F;
            arcScaleRange16.StartThickness = 14F;
            arcScaleRange17.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00C000");
            arcScaleRange17.EndThickness = 14F;
            arcScaleRange17.EndValue = 66F;
            arcScaleRange17.Name = "Range1";
            arcScaleRange17.ShapeOffset = 0F;
            arcScaleRange17.StartThickness = 14F;
            arcScaleRange17.StartValue = 33F;
            arcScaleRange18.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
            arcScaleRange18.EndThickness = 14F;
            arcScaleRange18.EndValue = 100F;
            arcScaleRange18.Name = "Range2";
            arcScaleRange18.ShapeOffset = 0F;
            arcScaleRange18.StartThickness = 14F;
            arcScaleRange18.StartValue = 66F;
            this.arcScaleComponent1.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            arcScaleRange16,
            arcScaleRange17,
            arcScaleRange18});
            this.arcScaleComponent1.StartAngle = -240F;
            this.arcScaleComponent1.Value = 80F;
            // 
            // arcScaleNeedleComponent1
            // 
            this.arcScaleNeedleComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleNeedleComponent1.EndOffset = 5F;
            this.arcScaleNeedleComponent1.Name = "needle";
            this.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style16;
            this.arcScaleNeedleComponent1.ZOrder = -50;
            // 
            // arcScaleSpindleCapComponent1
            // 
            this.arcScaleSpindleCapComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleSpindleCapComponent1.Name = "cGauge1_SpindleCap1";
            this.arcScaleSpindleCapComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style16;
            this.arcScaleSpindleCapComponent1.Size = new System.Drawing.SizeF(25F, 25F);
            this.arcScaleSpindleCapComponent1.ZOrder = -100;
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.AutoLayout = false;
            this.gaugeControl1.Controls.Add(this.lblBanburyLine1MCMax);
            this.gaugeControl1.Controls.Add(this.lblBanburyLine1MCMin);
            this.gaugeControl1.Controls.Add(this.lblBanburyLine1MC);
            this.gaugeControl1.Controls.Add(this.label1);
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.lnBanburyMC1});
            this.gaugeControl1.Location = new System.Drawing.Point(9, 55);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(287, 211);
            this.gaugeControl1.TabIndex = 0;
            // 
            // lblBanburyLine1MCMax
            // 
            this.lblBanburyLine1MCMax.AutoSize = true;
            this.lblBanburyLine1MCMax.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanburyLine1MCMax.ForeColor = System.Drawing.Color.Black;
            this.lblBanburyLine1MCMax.Location = new System.Drawing.Point(162, 115);
            this.lblBanburyLine1MCMax.Name = "lblBanburyLine1MCMax";
            this.lblBanburyLine1MCMax.Size = new System.Drawing.Size(86, 23);
            this.lblBanburyLine1MCMax.TabIndex = 5;
            this.lblBanburyLine1MCMax.Text = "Max :  0°C";
            // 
            // lblBanburyLine1MCMin
            // 
            this.lblBanburyLine1MCMin.AutoSize = true;
            this.lblBanburyLine1MCMin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanburyLine1MCMin.ForeColor = System.Drawing.Color.Black;
            this.lblBanburyLine1MCMin.Location = new System.Drawing.Point(161, 65);
            this.lblBanburyLine1MCMin.Name = "lblBanburyLine1MCMin";
            this.lblBanburyLine1MCMin.Size = new System.Drawing.Size(83, 23);
            this.lblBanburyLine1MCMin.TabIndex = 4;
            this.lblBanburyLine1MCMin.Text = "Min :  0°C";
            // 
            // lblBanburyLine1MC
            // 
            this.lblBanburyLine1MC.AutoSize = true;
            this.lblBanburyLine1MC.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanburyLine1MC.ForeColor = System.Drawing.Color.Black;
            this.lblBanburyLine1MC.Location = new System.Drawing.Point(161, 173);
            this.lblBanburyLine1MC.Name = "lblBanburyLine1MC";
            this.lblBanburyLine1MC.Size = new System.Drawing.Size(86, 23);
            this.lblBanburyLine1MC.TabIndex = 3;
            this.lblBanburyLine1MC.Text = "M/C :  0°C";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Machine 1";
            // 
            // lnBanburyMC1
            // 
            this.lnBanburyMC1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent[] {
            this.linearScaleBackgroundLayerComponent1});
            this.lnBanburyMC1.Bounds = new System.Drawing.Rectangle(6, 6, 150, 199);
            this.lnBanburyMC1.Levels.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent[] {
            this.linearScaleLevelComponent1});
            this.lnBanburyMC1.Name = "lnBanburyMC1";
            this.lnBanburyMC1.OptionsToolTip.TooltipTitleFormat = "{0}";
            this.lnBanburyMC1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent[] {
            this.lnScaleCompBanburyMC1});
            // 
            // linearScaleBackgroundLayerComponent1
            // 
            this.linearScaleBackgroundLayerComponent1.LinearScale = this.linearScaleComponent5;
            this.linearScaleBackgroundLayerComponent1.Name = "bg1";
            this.linearScaleBackgroundLayerComponent1.ScaleStartPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.85F);
            this.linearScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style25;
            this.linearScaleBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // linearScaleLevelComponent1
            // 
            this.linearScaleLevelComponent1.LinearScale = this.lnScaleCompBanburyMC1;
            this.linearScaleLevelComponent1.Name = "level1";
            this.linearScaleLevelComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style25;
            this.linearScaleLevelComponent1.ZOrder = -50;
            // 
            // lnScaleCompBanburyMC1
            // 
            this.lnScaleCompBanburyMC1.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.lnScaleCompBanburyMC1.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.lnScaleCompBanburyMC1.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.lnScaleCompBanburyMC1.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.lnScaleCompBanburyMC1.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lnScaleCompBanburyMC1.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.lnScaleCompBanburyMC1.EndPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 38F);
            this.lnScaleCompBanburyMC1.MajorTickCount = 6;
            this.lnScaleCompBanburyMC1.MajorTickmark.FormatString = "{0:F0}";
            this.lnScaleCompBanburyMC1.MajorTickmark.ShapeOffset = -25F;
            this.lnScaleCompBanburyMC1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style25_1;
            this.lnScaleCompBanburyMC1.MajorTickmark.TextOffset = -35F;
            this.lnScaleCompBanburyMC1.MaxValue = 100F;
            this.lnScaleCompBanburyMC1.MinorTickCount = 4;
            this.lnScaleCompBanburyMC1.MinorTickmark.ShapeOffset = -22F;
            this.lnScaleCompBanburyMC1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style25_2;
            this.lnScaleCompBanburyMC1.Name = "scale1";
            linearScaleRange40.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
            linearScaleRange40.EndThickness = 3F;
            linearScaleRange40.EndValue = 33F;
            linearScaleRange40.Name = "Range0";
            linearScaleRange40.ShapeOffset = -12F;
            linearScaleRange40.StartThickness = 3F;
            linearScaleRange41.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00C000");
            linearScaleRange41.EndThickness = 3F;
            linearScaleRange41.EndValue = 66F;
            linearScaleRange41.Name = "Range1";
            linearScaleRange41.ShapeOffset = -12F;
            linearScaleRange41.StartThickness = 3F;
            linearScaleRange41.StartValue = 33F;
            linearScaleRange42.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
            linearScaleRange42.EndThickness = 3F;
            linearScaleRange42.EndValue = 100F;
            linearScaleRange42.Name = "Range2";
            linearScaleRange42.ShapeOffset = -12F;
            linearScaleRange42.StartThickness = 3F;
            linearScaleRange42.StartValue = 66F;
            this.lnScaleCompBanburyMC1.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            linearScaleRange40,
            linearScaleRange41,
            linearScaleRange42});
            this.lnScaleCompBanburyMC1.StartPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 212F);
            this.lnScaleCompBanburyMC1.Value = 50F;
            // 
            // groupBoxEx6
            // 
            this.groupBoxEx6.BackgroundPanelImage = null;
            this.groupBoxEx6.Controls.Add(this.chartCalendar);
            this.groupBoxEx6.Controls.Add(this.chartRoll2);
            this.groupBoxEx6.DrawGroupBorder = true;
            this.groupBoxEx6.GroupBorderColor = System.Drawing.Color.Black;
            this.groupBoxEx6.GroupPanelColor = System.Drawing.SystemColors.Control;
            this.groupBoxEx6.GroupPanelShape = Smart_FTY.ClassLib.GroupBoxEx.PanelType.Rounded;
            this.groupBoxEx6.GroupPanelWith = 1F;
            this.groupBoxEx6.Location = new System.Drawing.Point(1257, 447);
            this.groupBoxEx6.Name = "groupBoxEx6";
            this.groupBoxEx6.Size = new System.Drawing.Size(656, 433);
            this.groupBoxEx6.TabIndex = 56;
            this.groupBoxEx6.TabStop = false;
            this.groupBoxEx6.TextBackColor = System.Drawing.Color.White;
            this.groupBoxEx6.TextBorderColor = System.Drawing.Color.Black;
            this.groupBoxEx6.TextBorderWith = 1F;
            // 
            // chartCalendar
            // 
            this.chartCalendar.DataBindings = null;
            xyDiagram5.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram5.AxisY.GridLines.Visible = false;
            xyDiagram5.AxisY.VisibleInPanesSerializable = "-1";
            this.chartCalendar.Diagram = xyDiagram5;
            this.chartCalendar.Legend.Name = "Default Legend";
            this.chartCalendar.Location = new System.Drawing.Point(6, 221);
            this.chartCalendar.Name = "chartCalendar";
            series5.Name = "Series 1";
            series5.View = splineSeriesView5;
            this.chartCalendar.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series5};
            this.chartCalendar.Size = new System.Drawing.Size(642, 210);
            this.chartCalendar.TabIndex = 3;
            // 
            // chartRoll2
            // 
            this.chartRoll2.DataBindings = null;
            xyDiagram6.AxisX.Label.ResolveOverlappingOptions.AllowHide = false;
            xyDiagram6.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram6.AxisY.GridLines.Visible = false;
            xyDiagram6.AxisY.NumericScaleOptions.AutoGrid = false;
            xyDiagram6.AxisY.Tickmarks.Visible = false;
            xyDiagram6.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram6.AxisY.VisibleInPanesSerializable = "-1";
            this.chartRoll2.Diagram = xyDiagram6;
            this.chartRoll2.Legend.Name = "Default Legend";
            this.chartRoll2.Location = new System.Drawing.Point(7, 1);
            this.chartRoll2.Name = "chartRoll2";
            series6.Name = "Series 1";
            series6.View = splineSeriesView6;
            this.chartRoll2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series6};
            this.chartRoll2.Size = new System.Drawing.Size(642, 217);
            this.chartRoll2.TabIndex = 2;
            // 
            // groupBoxEx4
            // 
            this.groupBoxEx4.BackgroundPanelImage = null;
            this.groupBoxEx4.Controls.Add(this.gaugeControl9);
            this.groupBoxEx4.Controls.Add(this.gaugeControl10);
            this.groupBoxEx4.Controls.Add(this.gaugeControl11);
            this.groupBoxEx4.Controls.Add(this.gaugeControl12);
            this.groupBoxEx4.DrawGroupBorder = true;
            this.groupBoxEx4.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEx4.ForeColor = System.Drawing.Color.White;
            this.groupBoxEx4.GroupBorderColor = System.Drawing.Color.Black;
            this.groupBoxEx4.GroupPanelColor = System.Drawing.SystemColors.Control;
            this.groupBoxEx4.GroupPanelShape = Smart_FTY.ClassLib.GroupBoxEx.PanelType.Rounded;
            this.groupBoxEx4.GroupPanelWith = 1F;
            this.groupBoxEx4.Location = new System.Drawing.Point(3, 447);
            this.groupBoxEx4.Name = "groupBoxEx4";
            this.groupBoxEx4.Size = new System.Drawing.Size(621, 439);
            this.groupBoxEx4.TabIndex = 53;
            this.groupBoxEx4.TabStop = false;
            this.groupBoxEx4.Text = "CALENDAR";
            this.groupBoxEx4.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBoxEx4.TextBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBoxEx4.TextBorderWith = 1F;
            // 
            // gaugeControl9
            // 
            this.gaugeControl9.AutoLayout = false;
            this.gaugeControl9.Controls.Add(this.label27);
            this.gaugeControl9.Controls.Add(this.lblCalendarLine2MatMax);
            this.gaugeControl9.Controls.Add(this.lblCalendarLine2MatMin);
            this.gaugeControl9.Controls.Add(this.lblCalendarLine2Mat);
            this.gaugeControl9.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.cirCalendarMat2});
            this.gaugeControl9.Location = new System.Drawing.Point(322, 263);
            this.gaugeControl9.Name = "gaugeControl9";
            this.gaugeControl9.Size = new System.Drawing.Size(289, 170);
            this.gaugeControl9.TabIndex = 53;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Teal;
            this.label27.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(163, 7);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(116, 29);
            this.label27.TabIndex = 13;
            this.label27.Text = "Material 2";
            // 
            // lblCalendarLine2MatMax
            // 
            this.lblCalendarLine2MatMax.AutoSize = true;
            this.lblCalendarLine2MatMax.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendarLine2MatMax.ForeColor = System.Drawing.Color.Black;
            this.lblCalendarLine2MatMax.Location = new System.Drawing.Point(164, 92);
            this.lblCalendarLine2MatMax.Name = "lblCalendarLine2MatMax";
            this.lblCalendarLine2MatMax.Size = new System.Drawing.Size(86, 23);
            this.lblCalendarLine2MatMax.TabIndex = 12;
            this.lblCalendarLine2MatMax.Text = "Max :  0°C";
            // 
            // lblCalendarLine2MatMin
            // 
            this.lblCalendarLine2MatMin.AutoSize = true;
            this.lblCalendarLine2MatMin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendarLine2MatMin.ForeColor = System.Drawing.Color.Black;
            this.lblCalendarLine2MatMin.Location = new System.Drawing.Point(164, 47);
            this.lblCalendarLine2MatMin.Name = "lblCalendarLine2MatMin";
            this.lblCalendarLine2MatMin.Size = new System.Drawing.Size(83, 23);
            this.lblCalendarLine2MatMin.TabIndex = 11;
            this.lblCalendarLine2MatMin.Text = "Min :  0°C";
            // 
            // lblCalendarLine2Mat
            // 
            this.lblCalendarLine2Mat.AutoSize = true;
            this.lblCalendarLine2Mat.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendarLine2Mat.ForeColor = System.Drawing.Color.Black;
            this.lblCalendarLine2Mat.Location = new System.Drawing.Point(164, 139);
            this.lblCalendarLine2Mat.Name = "lblCalendarLine2Mat";
            this.lblCalendarLine2Mat.Size = new System.Drawing.Size(79, 23);
            this.lblCalendarLine2Mat.TabIndex = 10;
            this.lblCalendarLine2Mat.Text = "Mtl :  0°C";
            // 
            // cirCalendarMat2
            // 
            this.cirCalendarMat2.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent3});
            this.cirCalendarMat2.Bounds = new System.Drawing.Rectangle(6, 6, 154, 170);
            this.cirCalendarMat2.Name = "cirCalendarMat2";
            this.cirCalendarMat2.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent3});
            this.cirCalendarMat2.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent3});
            this.cirCalendarMat2.SpindleCaps.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent[] {
            this.arcScaleSpindleCapComponent3});
            // 
            // arcScaleBackgroundLayerComponent3
            // 
            this.arcScaleBackgroundLayerComponent3.ArcScale = this.arcScaleComponent3;
            this.arcScaleBackgroundLayerComponent3.Name = "bg";
            this.arcScaleBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style16;
            this.arcScaleBackgroundLayerComponent3.ZOrder = 1000;
            // 
            // arcScaleComponent3
            // 
            this.arcScaleComponent3.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent3.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent3.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent3.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent3.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.arcScaleComponent3.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A");
            this.arcScaleComponent3.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F);
            this.arcScaleComponent3.EndAngle = 60F;
            this.arcScaleComponent3.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent3.MajorTickmark.ShapeOffset = -14F;
            this.arcScaleComponent3.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1;
            this.arcScaleComponent3.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent3.MaxValue = 100F;
            this.arcScaleComponent3.MinorTickCount = 4;
            this.arcScaleComponent3.MinorTickmark.ShapeOffset = -7F;
            this.arcScaleComponent3.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2;
            this.arcScaleComponent3.Name = "scale1";
            arcScaleRange19.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
            arcScaleRange19.EndThickness = 14F;
            arcScaleRange19.EndValue = 33F;
            arcScaleRange19.Name = "Range0";
            arcScaleRange19.ShapeOffset = 0F;
            arcScaleRange19.StartThickness = 14F;
            arcScaleRange20.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00C000");
            arcScaleRange20.EndThickness = 14F;
            arcScaleRange20.EndValue = 66F;
            arcScaleRange20.Name = "Range1";
            arcScaleRange20.ShapeOffset = 0F;
            arcScaleRange20.StartThickness = 14F;
            arcScaleRange20.StartValue = 33F;
            arcScaleRange21.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
            arcScaleRange21.EndThickness = 14F;
            arcScaleRange21.EndValue = 100F;
            arcScaleRange21.Name = "Range2";
            arcScaleRange21.ShapeOffset = 0F;
            arcScaleRange21.StartThickness = 14F;
            arcScaleRange21.StartValue = 66F;
            this.arcScaleComponent3.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            arcScaleRange19,
            arcScaleRange20,
            arcScaleRange21});
            this.arcScaleComponent3.StartAngle = -240F;
            this.arcScaleComponent3.Value = 80F;
            // 
            // arcScaleNeedleComponent3
            // 
            this.arcScaleNeedleComponent3.ArcScale = this.arcScaleComponent3;
            this.arcScaleNeedleComponent3.EndOffset = 5F;
            this.arcScaleNeedleComponent3.Name = "needle";
            this.arcScaleNeedleComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style16;
            this.arcScaleNeedleComponent3.ZOrder = -50;
            // 
            // arcScaleSpindleCapComponent3
            // 
            this.arcScaleSpindleCapComponent3.ArcScale = this.arcScaleComponent3;
            this.arcScaleSpindleCapComponent3.Name = "cGauge1_SpindleCap1";
            this.arcScaleSpindleCapComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style16;
            this.arcScaleSpindleCapComponent3.Size = new System.Drawing.SizeF(25F, 25F);
            this.arcScaleSpindleCapComponent3.ZOrder = -100;
            // 
            // gaugeControl10
            // 
            this.gaugeControl10.AutoLayout = false;
            this.gaugeControl10.Controls.Add(this.lblCalendarLine2MCMax);
            this.gaugeControl10.Controls.Add(this.lblCalendarLine2MCMin);
            this.gaugeControl10.Controls.Add(this.lblCalendarLine2MC);
            this.gaugeControl10.Controls.Add(this.label22);
            this.gaugeControl10.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.lnCalendarMC2});
            this.gaugeControl10.Location = new System.Drawing.Point(322, 57);
            this.gaugeControl10.Name = "gaugeControl10";
            this.gaugeControl10.Size = new System.Drawing.Size(289, 200);
            this.gaugeControl10.TabIndex = 53;
            // 
            // lblCalendarLine2MCMax
            // 
            this.lblCalendarLine2MCMax.AutoSize = true;
            this.lblCalendarLine2MCMax.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendarLine2MCMax.ForeColor = System.Drawing.Color.Black;
            this.lblCalendarLine2MCMax.Location = new System.Drawing.Point(164, 111);
            this.lblCalendarLine2MCMax.Name = "lblCalendarLine2MCMax";
            this.lblCalendarLine2MCMax.Size = new System.Drawing.Size(86, 23);
            this.lblCalendarLine2MCMax.TabIndex = 9;
            this.lblCalendarLine2MCMax.Text = "Max :  0°C";
            // 
            // lblCalendarLine2MCMin
            // 
            this.lblCalendarLine2MCMin.AutoSize = true;
            this.lblCalendarLine2MCMin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendarLine2MCMin.ForeColor = System.Drawing.Color.Black;
            this.lblCalendarLine2MCMin.Location = new System.Drawing.Point(164, 61);
            this.lblCalendarLine2MCMin.Name = "lblCalendarLine2MCMin";
            this.lblCalendarLine2MCMin.Size = new System.Drawing.Size(83, 23);
            this.lblCalendarLine2MCMin.TabIndex = 8;
            this.lblCalendarLine2MCMin.Text = "Min :  0°C";
            // 
            // lblCalendarLine2MC
            // 
            this.lblCalendarLine2MC.AutoSize = true;
            this.lblCalendarLine2MC.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendarLine2MC.ForeColor = System.Drawing.Color.Black;
            this.lblCalendarLine2MC.Location = new System.Drawing.Point(164, 164);
            this.lblCalendarLine2MC.Name = "lblCalendarLine2MC";
            this.lblCalendarLine2MC.Size = new System.Drawing.Size(86, 23);
            this.lblCalendarLine2MC.TabIndex = 7;
            this.lblCalendarLine2MC.Text = "M/C :  0°C";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Teal;
            this.label22.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(167, 6);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(117, 29);
            this.label22.TabIndex = 6;
            this.label22.Text = "Machine 2";
            // 
            // lnCalendarMC2
            // 
            this.lnCalendarMC2.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent[] {
            this.linearScaleBackgroundLayerComponent7});
            this.lnCalendarMC2.Bounds = new System.Drawing.Rectangle(6, 6, 153, 188);
            this.lnCalendarMC2.Levels.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent[] {
            this.linearScaleLevelComponent7});
            this.lnCalendarMC2.Name = "lnCalendarMC2";
            this.lnCalendarMC2.OptionsToolTip.TooltipTitleFormat = "{0}";
            this.lnCalendarMC2.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent[] {
            this.linearScaleComponent7});
            // 
            // linearScaleBackgroundLayerComponent7
            // 
            this.linearScaleBackgroundLayerComponent7.LinearScale = this.linearScaleComponent7;
            this.linearScaleBackgroundLayerComponent7.Name = "bg1";
            this.linearScaleBackgroundLayerComponent7.ScaleStartPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.85F);
            this.linearScaleBackgroundLayerComponent7.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style25;
            this.linearScaleBackgroundLayerComponent7.ZOrder = 1000;
            // 
            // linearScaleComponent7
            // 
            this.linearScaleComponent7.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent7.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent7.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent7.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent7.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 8F);
            this.linearScaleComponent7.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent7.EndPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 38F);
            this.linearScaleComponent7.MajorTickCount = 6;
            this.linearScaleComponent7.MajorTickmark.FormatString = "{0:F0}";
            this.linearScaleComponent7.MajorTickmark.ShapeOffset = -25F;
            this.linearScaleComponent7.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style25_1;
            this.linearScaleComponent7.MajorTickmark.TextOffset = -35F;
            this.linearScaleComponent7.MaxValue = 100F;
            this.linearScaleComponent7.MinorTickCount = 4;
            this.linearScaleComponent7.MinorTickmark.ShapeOffset = -22F;
            this.linearScaleComponent7.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style25_2;
            this.linearScaleComponent7.Name = "scale1";
            linearScaleRange43.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
            linearScaleRange43.EndThickness = 3F;
            linearScaleRange43.EndValue = 33F;
            linearScaleRange43.Name = "Range0";
            linearScaleRange43.ShapeOffset = -12F;
            linearScaleRange43.StartThickness = 3F;
            linearScaleRange44.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00C000");
            linearScaleRange44.EndThickness = 3F;
            linearScaleRange44.EndValue = 66F;
            linearScaleRange44.Name = "Range1";
            linearScaleRange44.ShapeOffset = -12F;
            linearScaleRange44.StartThickness = 3F;
            linearScaleRange44.StartValue = 33F;
            linearScaleRange45.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
            linearScaleRange45.EndThickness = 3F;
            linearScaleRange45.EndValue = 100F;
            linearScaleRange45.Name = "Range2";
            linearScaleRange45.ShapeOffset = -12F;
            linearScaleRange45.StartThickness = 3F;
            linearScaleRange45.StartValue = 66F;
            this.linearScaleComponent7.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            linearScaleRange43,
            linearScaleRange44,
            linearScaleRange45});
            this.linearScaleComponent7.StartPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 212F);
            this.linearScaleComponent7.Value = 50F;
            // 
            // linearScaleLevelComponent7
            // 
            this.linearScaleLevelComponent7.LinearScale = this.linearScaleComponent7;
            this.linearScaleLevelComponent7.Name = "level1";
            this.linearScaleLevelComponent7.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style25;
            this.linearScaleLevelComponent7.ZOrder = -50;
            // 
            // gaugeControl11
            // 
            this.gaugeControl11.AutoLayout = false;
            this.gaugeControl11.Controls.Add(this.label23);
            this.gaugeControl11.Controls.Add(this.lblCalendarLine1MatMax);
            this.gaugeControl11.Controls.Add(this.lblCalendarLine1MatMin);
            this.gaugeControl11.Controls.Add(this.lblCalendarLine1Mat);
            this.gaugeControl11.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.cirCalendarMat1});
            this.gaugeControl11.Location = new System.Drawing.Point(8, 262);
            this.gaugeControl11.Name = "gaugeControl11";
            this.gaugeControl11.Size = new System.Drawing.Size(287, 172);
            this.gaugeControl11.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Teal;
            this.label23.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(164, 7);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(116, 29);
            this.label23.TabIndex = 13;
            this.label23.Text = "Material 1";
            // 
            // lblCalendarLine1MatMax
            // 
            this.lblCalendarLine1MatMax.AutoSize = true;
            this.lblCalendarLine1MatMax.BackColor = System.Drawing.Color.White;
            this.lblCalendarLine1MatMax.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendarLine1MatMax.ForeColor = System.Drawing.Color.Black;
            this.lblCalendarLine1MatMax.Location = new System.Drawing.Point(160, 94);
            this.lblCalendarLine1MatMax.Name = "lblCalendarLine1MatMax";
            this.lblCalendarLine1MatMax.Size = new System.Drawing.Size(86, 23);
            this.lblCalendarLine1MatMax.TabIndex = 12;
            this.lblCalendarLine1MatMax.Text = "Max :  0°C";
            // 
            // lblCalendarLine1MatMin
            // 
            this.lblCalendarLine1MatMin.AutoSize = true;
            this.lblCalendarLine1MatMin.BackColor = System.Drawing.Color.White;
            this.lblCalendarLine1MatMin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendarLine1MatMin.ForeColor = System.Drawing.Color.Black;
            this.lblCalendarLine1MatMin.Location = new System.Drawing.Point(160, 51);
            this.lblCalendarLine1MatMin.Name = "lblCalendarLine1MatMin";
            this.lblCalendarLine1MatMin.Size = new System.Drawing.Size(83, 23);
            this.lblCalendarLine1MatMin.TabIndex = 11;
            this.lblCalendarLine1MatMin.Text = "Min :  0°C";
            // 
            // lblCalendarLine1Mat
            // 
            this.lblCalendarLine1Mat.AutoSize = true;
            this.lblCalendarLine1Mat.BackColor = System.Drawing.Color.White;
            this.lblCalendarLine1Mat.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendarLine1Mat.ForeColor = System.Drawing.Color.Black;
            this.lblCalendarLine1Mat.Location = new System.Drawing.Point(160, 143);
            this.lblCalendarLine1Mat.Name = "lblCalendarLine1Mat";
            this.lblCalendarLine1Mat.Size = new System.Drawing.Size(79, 23);
            this.lblCalendarLine1Mat.TabIndex = 10;
            this.lblCalendarLine1Mat.Text = "Mtl :  0°C";
            // 
            // cirCalendarMat1
            // 
            this.cirCalendarMat1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent4});
            this.cirCalendarMat1.Bounds = new System.Drawing.Rectangle(6, 6, 150, 170);
            this.cirCalendarMat1.Name = "cirCalendarMat1";
            this.cirCalendarMat1.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent4});
            this.cirCalendarMat1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent4});
            this.cirCalendarMat1.SpindleCaps.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent[] {
            this.arcScaleSpindleCapComponent4});
            // 
            // arcScaleBackgroundLayerComponent4
            // 
            this.arcScaleBackgroundLayerComponent4.ArcScale = this.arcScaleComponent4;
            this.arcScaleBackgroundLayerComponent4.Name = "bg";
            this.arcScaleBackgroundLayerComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style16;
            this.arcScaleBackgroundLayerComponent4.ZOrder = 1000;
            // 
            // arcScaleComponent4
            // 
            this.arcScaleComponent4.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent4.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent4.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent4.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.arcScaleComponent4.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.arcScaleComponent4.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A");
            this.arcScaleComponent4.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F);
            this.arcScaleComponent4.EndAngle = 60F;
            this.arcScaleComponent4.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent4.MajorTickmark.ShapeOffset = -14F;
            this.arcScaleComponent4.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1;
            this.arcScaleComponent4.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent4.MaxValue = 100F;
            this.arcScaleComponent4.MinorTickCount = 4;
            this.arcScaleComponent4.MinorTickmark.ShapeOffset = -7F;
            this.arcScaleComponent4.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2;
            this.arcScaleComponent4.Name = "scale1";
            arcScaleRange22.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
            arcScaleRange22.EndThickness = 14F;
            arcScaleRange22.EndValue = 33F;
            arcScaleRange22.Name = "Range0";
            arcScaleRange22.ShapeOffset = 0F;
            arcScaleRange22.StartThickness = 14F;
            arcScaleRange23.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00C000");
            arcScaleRange23.EndThickness = 14F;
            arcScaleRange23.EndValue = 66F;
            arcScaleRange23.Name = "Range1";
            arcScaleRange23.ShapeOffset = 0F;
            arcScaleRange23.StartThickness = 14F;
            arcScaleRange23.StartValue = 33F;
            arcScaleRange24.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
            arcScaleRange24.EndThickness = 14F;
            arcScaleRange24.EndValue = 100F;
            arcScaleRange24.Name = "Range2";
            arcScaleRange24.ShapeOffset = 0F;
            arcScaleRange24.StartThickness = 14F;
            arcScaleRange24.StartValue = 66F;
            this.arcScaleComponent4.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            arcScaleRange22,
            arcScaleRange23,
            arcScaleRange24});
            this.arcScaleComponent4.StartAngle = -240F;
            this.arcScaleComponent4.Value = 80F;
            // 
            // arcScaleNeedleComponent4
            // 
            this.arcScaleNeedleComponent4.ArcScale = this.arcScaleComponent4;
            this.arcScaleNeedleComponent4.EndOffset = 5F;
            this.arcScaleNeedleComponent4.Name = "needle";
            this.arcScaleNeedleComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style16;
            this.arcScaleNeedleComponent4.ZOrder = -50;
            // 
            // arcScaleSpindleCapComponent4
            // 
            this.arcScaleSpindleCapComponent4.ArcScale = this.arcScaleComponent4;
            this.arcScaleSpindleCapComponent4.Name = "cGauge1_SpindleCap1";
            this.arcScaleSpindleCapComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style16;
            this.arcScaleSpindleCapComponent4.Size = new System.Drawing.SizeF(25F, 25F);
            this.arcScaleSpindleCapComponent4.ZOrder = -100;
            // 
            // gaugeControl12
            // 
            this.gaugeControl12.AutoLayout = false;
            this.gaugeControl12.Controls.Add(this.lblCalendarLine1MCMax);
            this.gaugeControl12.Controls.Add(this.lblCalendarLine1MCMin);
            this.gaugeControl12.Controls.Add(this.lblCalendarLine1MC);
            this.gaugeControl12.Controls.Add(this.label18);
            this.gaugeControl12.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.lnCalendarMC1});
            this.gaugeControl12.Location = new System.Drawing.Point(9, 55);
            this.gaugeControl12.Name = "gaugeControl12";
            this.gaugeControl12.Size = new System.Drawing.Size(287, 201);
            this.gaugeControl12.TabIndex = 0;
            // 
            // lblCalendarLine1MCMax
            // 
            this.lblCalendarLine1MCMax.AutoSize = true;
            this.lblCalendarLine1MCMax.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendarLine1MCMax.ForeColor = System.Drawing.Color.Black;
            this.lblCalendarLine1MCMax.Location = new System.Drawing.Point(162, 107);
            this.lblCalendarLine1MCMax.Name = "lblCalendarLine1MCMax";
            this.lblCalendarLine1MCMax.Size = new System.Drawing.Size(86, 23);
            this.lblCalendarLine1MCMax.TabIndex = 9;
            this.lblCalendarLine1MCMax.Text = "Max :  0°C";
            // 
            // lblCalendarLine1MCMin
            // 
            this.lblCalendarLine1MCMin.AutoSize = true;
            this.lblCalendarLine1MCMin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendarLine1MCMin.ForeColor = System.Drawing.Color.Black;
            this.lblCalendarLine1MCMin.Location = new System.Drawing.Point(161, 57);
            this.lblCalendarLine1MCMin.Name = "lblCalendarLine1MCMin";
            this.lblCalendarLine1MCMin.Size = new System.Drawing.Size(83, 23);
            this.lblCalendarLine1MCMin.TabIndex = 8;
            this.lblCalendarLine1MCMin.Text = "Min :  0°C";
            // 
            // lblCalendarLine1MC
            // 
            this.lblCalendarLine1MC.AutoSize = true;
            this.lblCalendarLine1MC.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendarLine1MC.ForeColor = System.Drawing.Color.Black;
            this.lblCalendarLine1MC.Location = new System.Drawing.Point(161, 165);
            this.lblCalendarLine1MC.Name = "lblCalendarLine1MC";
            this.lblCalendarLine1MC.Size = new System.Drawing.Size(86, 23);
            this.lblCalendarLine1MC.TabIndex = 7;
            this.lblCalendarLine1MC.Text = "M/C :  0°C";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Teal;
            this.label18.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(166, 5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(117, 29);
            this.label18.TabIndex = 6;
            this.label18.Text = "Machine 1";
            // 
            // lnCalendarMC1
            // 
            this.lnCalendarMC1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent[] {
            this.linearScaleBackgroundLayerComponent8});
            this.lnCalendarMC1.Bounds = new System.Drawing.Rectangle(6, 6, 150, 189);
            this.lnCalendarMC1.Levels.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent[] {
            this.linearScaleLevelComponent8});
            this.lnCalendarMC1.Name = "lnCalendarMC1";
            this.lnCalendarMC1.OptionsToolTip.TooltipTitleFormat = "{0}";
            this.lnCalendarMC1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent[] {
            this.linearScaleComponent8});
            // 
            // linearScaleBackgroundLayerComponent8
            // 
            this.linearScaleBackgroundLayerComponent8.LinearScale = this.linearScaleComponent8;
            this.linearScaleBackgroundLayerComponent8.Name = "bg1";
            this.linearScaleBackgroundLayerComponent8.ScaleStartPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.85F);
            this.linearScaleBackgroundLayerComponent8.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style25;
            this.linearScaleBackgroundLayerComponent8.ZOrder = 1000;
            // 
            // linearScaleComponent8
            // 
            this.linearScaleComponent8.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent8.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent8.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent8.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent8.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 8F);
            this.linearScaleComponent8.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent8.EndPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 38F);
            this.linearScaleComponent8.MajorTickCount = 6;
            this.linearScaleComponent8.MajorTickmark.FormatString = "{0:F0}";
            this.linearScaleComponent8.MajorTickmark.ShapeOffset = -25F;
            this.linearScaleComponent8.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style25_1;
            this.linearScaleComponent8.MajorTickmark.TextOffset = -35F;
            this.linearScaleComponent8.MaxValue = 100F;
            this.linearScaleComponent8.MinorTickCount = 4;
            this.linearScaleComponent8.MinorTickmark.ShapeOffset = -22F;
            this.linearScaleComponent8.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style25_2;
            this.linearScaleComponent8.Name = "scale1";
            linearScaleRange46.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
            linearScaleRange46.EndThickness = 3F;
            linearScaleRange46.EndValue = 33F;
            linearScaleRange46.Name = "Range0";
            linearScaleRange46.ShapeOffset = -12F;
            linearScaleRange46.StartThickness = 3F;
            linearScaleRange47.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00C000");
            linearScaleRange47.EndThickness = 3F;
            linearScaleRange47.EndValue = 66F;
            linearScaleRange47.Name = "Range1";
            linearScaleRange47.ShapeOffset = -12F;
            linearScaleRange47.StartThickness = 3F;
            linearScaleRange47.StartValue = 33F;
            linearScaleRange48.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Red");
            linearScaleRange48.EndThickness = 3F;
            linearScaleRange48.EndValue = 100F;
            linearScaleRange48.Name = "Range2";
            linearScaleRange48.ShapeOffset = -12F;
            linearScaleRange48.StartThickness = 3F;
            linearScaleRange48.StartValue = 66F;
            this.linearScaleComponent8.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            linearScaleRange46,
            linearScaleRange47,
            linearScaleRange48});
            this.linearScaleComponent8.StartPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 212F);
            this.linearScaleComponent8.Value = 50F;
            // 
            // linearScaleLevelComponent8
            // 
            this.linearScaleLevelComponent8.LinearScale = this.linearScaleComponent8;
            this.linearScaleLevelComponent8.Name = "level1";
            this.linearScaleLevelComponent8.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style25;
            this.linearScaleLevelComponent8.ZOrder = -50;
            // 
            // groupBoxEx5
            // 
            this.groupBoxEx5.BackgroundPanelImage = null;
            this.groupBoxEx5.Controls.Add(this.chartRoll1);
            this.groupBoxEx5.Controls.Add(this.chartBanbury);
            this.groupBoxEx5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEx5.DrawGroupBorder = true;
            this.groupBoxEx5.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEx5.ForeColor = System.Drawing.Color.White;
            this.groupBoxEx5.GroupBorderColor = System.Drawing.Color.Black;
            this.groupBoxEx5.GroupPanelColor = System.Drawing.SystemColors.Control;
            this.groupBoxEx5.GroupPanelShape = Smart_FTY.ClassLib.GroupBoxEx.PanelType.Rounded;
            this.groupBoxEx5.GroupPanelWith = 1F;
            this.groupBoxEx5.Location = new System.Drawing.Point(1257, 3);
            this.groupBoxEx5.Name = "groupBoxEx5";
            this.groupBoxEx5.Size = new System.Drawing.Size(656, 438);
            this.groupBoxEx5.TabIndex = 55;
            this.groupBoxEx5.TabStop = false;
            this.groupBoxEx5.Text = "HISTORY";
            this.groupBoxEx5.TextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBoxEx5.TextBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBoxEx5.TextBorderWith = 1F;
            // 
            // chartRoll1
            // 
            this.chartRoll1.DataBindings = null;
            xyDiagram7.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram7.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram7.AxisY.GridLines.Visible = false;
            xyDiagram7.AxisY.VisibleInPanesSerializable = "-1";
            this.chartRoll1.Diagram = xyDiagram7;
            this.chartRoll1.Legend.Name = "Default Legend";
            this.chartRoll1.Location = new System.Drawing.Point(9, 250);
            this.chartRoll1.Name = "chartRoll1";
            series7.Name = "Series 1";
            series7.View = splineSeriesView7;
            this.chartRoll1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series7};
            this.chartRoll1.Size = new System.Drawing.Size(642, 184);
            this.chartRoll1.TabIndex = 1;
            // 
            // chartBanbury
            // 
            this.chartBanbury.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chartBanbury.DataBindings = null;
            xyDiagram8.AxisX.Label.ResolveOverlappingOptions.AllowHide = false;
            xyDiagram8.AxisX.Label.ResolveOverlappingOptions.MinIndent = 2;
            xyDiagram8.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram8.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram8.AxisY.GridLines.Visible = false;
            xyDiagram8.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram8.AxisY.VisibleInPanesSerializable = "-1";
            this.chartBanbury.Diagram = xyDiagram8;
            this.chartBanbury.Legend.Name = "Default Legend";
            this.chartBanbury.Location = new System.Drawing.Point(9, 56);
            this.chartBanbury.Name = "chartBanbury";
            series8.Name = "Series 1";
            series8.View = splineSeriesView8;
            this.chartBanbury.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series8};
            this.chartBanbury.Size = new System.Drawing.Size(642, 187);
            this.chartBanbury.TabIndex = 0;
            // 
            // axGrid
            // 
            this.axGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axGrid.DataSource = null;
            this.axGrid.Location = new System.Drawing.Point(0, 4);
            this.axGrid.Name = "axGrid";
            this.axGrid.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGrid.OcxState")));
            this.axGrid.Size = new System.Drawing.Size(75, 63);
            this.axGrid.TabIndex = 0;
            this.axGrid.Visible = false;
            // 
            // tmrLoad
            // 
            this.tmrLoad.Interval = 1000;
            this.tmrLoad.Tick += new System.EventHandler(this.tmrLoad_Tick);
            // 
            // FRM_RUB_TEMP_TRACKING
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1916, 1054);
            this.Controls.Add(this.pn_body);
            this.Name = "FRM_RUB_TEMP_TRACKING";
            this.Text = "PR";
            this.Load += new System.EventHandler(this.FRM_RUB_TEMP_TRACKING_Load);
            this.VisibleChanged += new System.EventHandler(this.FRM_RUB_TEMP_TRACKING_VisibleChanged);
            this.Controls.SetChildIndex(this.pn_body, 0);
            this.Controls.SetChildIndex(this.pnHeader, 0);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.pnButton.ResumeLayout(false);
            this.pn_body.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnEVA.ResumeLayout(false);
            this.pnRubber.ResumeLayout(false);
            this.tpn_show.ResumeLayout(false);
            this.groupBoxEx2.ResumeLayout(false);
            this.gaugeControl5.ResumeLayout(false);
            this.gaugeControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lnRollMC12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleBackgroundLayerComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleLevelComponent3)).EndInit();
            this.gaugeControl8.ResumeLayout(false);
            this.gaugeControl8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lnRollMC11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleBackgroundLayerComponent4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleLevelComponent4)).EndInit();
            this.groupBoxEx3.ResumeLayout(false);
            this.gaugeControl6.ResumeLayout(false);
            this.gaugeControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lnRollMC22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleBackgroundLayerComponent5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleLevelComponent5)).EndInit();
            this.gaugeControl7.ResumeLayout(false);
            this.gaugeControl7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lnRollMC21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleBackgroundLayerComponent6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleLevelComponent6)).EndInit();
            this.groupBoxEx1.ResumeLayout(false);
            this.gaugeControl4.ResumeLayout(false);
            this.gaugeControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cirBanburyMat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent2)).EndInit();
            this.gaugeControl3.ResumeLayout(false);
            this.gaugeControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lnBanburyMC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleBackgroundLayerComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleLevelComponent2)).EndInit();
            this.gaugeControl2.ResumeLayout(false);
            this.gaugeControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cirBanburyMat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent1)).EndInit();
            this.gaugeControl1.ResumeLayout(false);
            this.gaugeControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lnBanburyMC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleLevelComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnScaleCompBanburyMC1)).EndInit();
            this.groupBoxEx6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCalendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRoll2)).EndInit();
            this.groupBoxEx4.ResumeLayout(false);
            this.gaugeControl9.ResumeLayout(false);
            this.gaugeControl9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cirCalendarMat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent3)).EndInit();
            this.gaugeControl10.ResumeLayout(false);
            this.gaugeControl10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lnCalendarMC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleBackgroundLayerComponent7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleLevelComponent7)).EndInit();
            this.gaugeControl11.ResumeLayout(false);
            this.gaugeControl11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cirCalendarMat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent4)).EndInit();
            this.gaugeControl12.ResumeLayout(false);
            this.gaugeControl12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lnCalendarMC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleBackgroundLayerComponent8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleLevelComponent8)).EndInit();
            this.groupBoxEx5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRoll1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBanbury)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axGrid)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Panel pn_body;
        private AxFPUSpreadADO.AxfpSpread axGrid;
        private System.Windows.Forms.TableLayoutPanel tpn_show;
        private ClassLib.GroupBoxEx groupBoxEx1;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge lnBanburyMC1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent linearScaleBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent lnScaleCompBanburyMC1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent linearScaleLevelComponent1;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge cirBanburyMat1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent arcScaleSpindleCapComponent1;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl4;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge cirBanburyMat2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent arcScaleSpindleCapComponent2;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl3;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge lnBanburyMC2;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent linearScaleBackgroundLayerComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent linearScaleComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent linearScaleLevelComponent2;
        private ClassLib.GroupBoxEx groupBoxEx2;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl8;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge lnRollMC11;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent linearScaleBackgroundLayerComponent4;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent linearScaleComponent4;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent linearScaleLevelComponent4;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl5;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge lnRollMC12;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent linearScaleBackgroundLayerComponent3;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent linearScaleComponent3;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent linearScaleLevelComponent3;
        private ClassLib.GroupBoxEx groupBoxEx3;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl6;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge lnRollMC22;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent linearScaleBackgroundLayerComponent5;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent linearScaleComponent5;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent linearScaleLevelComponent5;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl7;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge lnRollMC21;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent linearScaleBackgroundLayerComponent6;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent linearScaleComponent6;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent linearScaleLevelComponent6;
        private ClassLib.GroupBoxEx groupBoxEx4;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl9;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge cirCalendarMat2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent3;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent3;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent3;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent arcScaleSpindleCapComponent3;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl10;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge lnCalendarMC2;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent linearScaleBackgroundLayerComponent7;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent linearScaleComponent7;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent linearScaleLevelComponent7;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl11;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge cirCalendarMat1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent4;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent4;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent4;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent arcScaleSpindleCapComponent4;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl12;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge lnCalendarMC1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent linearScaleBackgroundLayerComponent8;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent linearScaleComponent8;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent linearScaleLevelComponent8;
        private ClassLib.GroupBoxEx groupBoxEx5;
        private DevExpress.XtraCharts.ChartControl chartRoll1;
        private DevExpress.XtraCharts.ChartControl chartBanbury;
        private ClassLib.GroupBoxEx groupBoxEx6;
        private DevExpress.XtraCharts.ChartControl chartCalendar;
        private DevExpress.XtraCharts.ChartControl chartRoll2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBanburyLine1MC;
        private System.Windows.Forms.Label lblBanburyLine2MC;
        private System.Windows.Forms.Label lblBanburyLine2Mat;
        private System.Windows.Forms.Label lblBanburyLine1Mat;
        private System.Windows.Forms.Label lblBanburyLine2MCMax;
        private System.Windows.Forms.Label lblBanburyLine2MCMin;
        private System.Windows.Forms.Label lblBanburyLine1MCMax;
        private System.Windows.Forms.Label lblBanburyLine1MCMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBanburyLine1MatMax;
        private System.Windows.Forms.Label lblBanburyLine1MatMin;
        private System.Windows.Forms.Label lblBanburyLine2MatMax;
        private System.Windows.Forms.Label lblBanburyLine2MatMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRoll1Line2MCMax;
        private System.Windows.Forms.Label lblRoll1Line2MCMin;
        private System.Windows.Forms.Label lblRoll1Line2MC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblRoll1Line1MCMax;
        private System.Windows.Forms.Label lblRoll1Line1MCMin;
        private System.Windows.Forms.Label lblRoll1Line1MC;
        private System.Windows.Forms.Label lblCalendarLine2MCMax;
        private System.Windows.Forms.Label lblCalendarLine2MCMin;
        private System.Windows.Forms.Label lblCalendarLine2MC;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblCalendarLine1MCMax;
        private System.Windows.Forms.Label lblCalendarLine1MCMin;
        private System.Windows.Forms.Label lblCalendarLine1MC;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblRoll2Line2MCMax;
        private System.Windows.Forms.Label lblRoll2Line2MCMin;
        private System.Windows.Forms.Label lblRoll2Line2MC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblRoll2Line1MCMax;
        private System.Windows.Forms.Label lblRoll2Line1MCMin;
        private System.Windows.Forms.Label lblRoll2Line1MC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblCalendarLine2MatMax;
        private System.Windows.Forms.Label lblCalendarLine2MatMin;
        private System.Windows.Forms.Label lblCalendarLine2Mat;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblCalendarLine1MatMax;
        private System.Windows.Forms.Label lblCalendarLine1MatMin;
        private System.Windows.Forms.Label lblCalendarLine1Mat;
        private Button btnEva;
        private Timer tmrBlindLable;
        private Panel panel2;
        private A1Panel pnEVA;
        private Label lblEVA;
        private A1Panel pnRubber;
        private Label lblRubber;
        private Timer tmrLoad;
       // private IContainer components;
        private Button btnRubber;
       // private ClassLib.TransparentPanel panel2;
       
    


        public FRM_RUB_TEMP_TRACKING()
        {
            InitializeComponent();
        }

        


       int indexScreen;
       public FRM_RUB_TEMP_TRACKING(string Title, int _indexScreen)
        {
            InitializeComponent();
            indexScreen = _indexScreen;
            //lblTitle.Text = Title;
        }
        
        #region Variable
        
        int icount = 0;
        bool _load;
        double iBanburyMC1 = 0, iBanburyMC2 = 0, iBanburyMat1 = 0, iBanburyMat2 = 0;
        double dBanburyMC1Min = 0, dBanburyMC1Max = 0, dBanburyMC2Min = 0, dBanburyMC2Max = 0, dBanburyMat1Min = 0, dBanburyMat1Max = 0, dBanburyMat2Min = 0, dBanburyMat2Max = 0;

        double iRoll1MC1 = 0, iRoll1MC2 = 0, iRoll2MC1 = 0, iRoll2MC2 = 0;
        double dRoll1MC1Min = 0, dRoll1MC1Max = 0, dRoll1MC2Min = 0, dRoll1MC2Max = 0, dRoll2MC1Min = 0, dRoll2MC1Max = 0, dRoll2MC2Min = 0, dRoll2MC2Max = 0;


        double iCalendarMC1 = 0, iCalendarMC2 = 0, iCalendarMat1 = 0, iCalendarMat2 = 0;
        double dCalendarMC1Min = 0, dCalendarMC1Max = 0, dCalendarMC2Min = 0, dCalendarMC2Max = 0, dCalendarMat1Min = 0, dCalendarMat1Max = 0, dCalendarMat2Min = 0, dCalendarMat2Max = 0;

        #endregion
     
        #region Func

        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }
        private Color ReverColor(Color cColor)
        {
            if (cColor == Color.Red)
            {
                return Color.White;
            }
            else if (cColor == Color.White)
                return Color.Red;
            else
                return cColor;
        }
        private void BlindLabel(Label lbl, double val, double minVal, double maxVal)
        {
            if (val < minVal || val > maxVal)
                lbl.BackColor = ReverColor(lbl.BackColor);
        }
        private void CreateChartLine(ChartControl arg_chart, DataTable arg_dt, string arg_name, string arg_serial_name)
        {
            if (arg_dt == null || arg_dt.Rows.Count == 0) return;


            
            //----------create--------------------
            arg_chart.Series.Clear();
            arg_chart.Titles.Clear();

            Series series2 = new Series(arg_serial_name, ViewType.Spline);

            DevExpress.XtraCharts.SplineSeriesView splineSeriesView1 = new DevExpress.XtraCharts.SplineSeriesView();
      
            DevExpress.XtraCharts.XYSeriesUnwindAnimation xySeriesUnwindAnimation1 = new DevExpress.XtraCharts.XYSeriesUnwindAnimation();
            DevExpress.XtraCharts.SineEasingFunction sineEasingFunction1 = new DevExpress.XtraCharts.SineEasingFunction();
            DevExpress.XtraCharts.ConstantLine constantLine1 = new DevExpress.XtraCharts.ConstantLine();
            DevExpress.XtraCharts.ConstantLine constantLine2 = new DevExpress.XtraCharts.ConstantLine();

            arg_chart.AnimationStartMode = ChartAnimationMode.OnDataChanged;

            //--------- Add data Point------------
            if (arg_dt != null && arg_dt.Rows.Count > 0)
            {

                for (int i = 0; i < arg_dt.Rows.Count; i++)
                {
                    series2.Points.Add(new SeriesPoint(arg_dt.Rows[i]["T_HMS"].ToString(), arg_dt.Rows[i]["VALUE"]));
                  
                }
                
            }
            series2.ArgumentScaleType = ScaleType.Qualitative;
            arg_chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] { series2 };

            //title
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            chartTitle2.Alignment = System.Drawing.StringAlignment.Near;
            chartTitle2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            chartTitle2.Text = arg_name;
            chartTitle2.TextColor = System.Drawing.Color.Blue;
            arg_chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {chartTitle2});


            //Constant line
            //constantLine1.ShowInLegend = false;
            constantLine1.AxisValueSerializable = arg_dt.Rows[0]["MINVAL"].ToString();
            constantLine1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            constantLine1.Name = "Min";
            constantLine2.AxisValueSerializable = arg_dt.Rows[0]["MAXVAL"].ToString();
            constantLine2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            constantLine2.Name = "Max";
            // constantLine1.ShowBehind = false;
            constantLine1.Title.Visible = false;
            constantLine1.Title.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //constantLine1.Title.Text = "Target";
            constantLine1.LineStyle.Thickness = 3;
            constantLine2.Title.Visible = false;
            constantLine2.Title.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //constantLine1.Title.Text = "Target";
            constantLine2.LineStyle.Thickness = 3;
            // constantLine1.Title.Alignment = DevExpress.XtraCharts.ConstantLineTitleAlignment.Far;
            ((XYDiagram)arg_chart.Diagram).AxisX.Label.ResolveOverlappingOptions.AllowHide = false;
            ((XYDiagram)arg_chart.Diagram).AxisY.ConstantLines.Clear();
            ((XYDiagram)arg_chart.Diagram).AxisY.ConstantLines.AddRange(new DevExpress.XtraCharts.ConstantLine[] { constantLine1, constantLine2 });


            // format Series 
           
           
            splineSeriesView1.LineStyle.Thickness = 3;
       
            series2.View = splineSeriesView1;
            
            xySeriesUnwindAnimation1.EasingFunction = sineEasingFunction1;
            splineSeriesView1.SeriesAnimation = xySeriesUnwindAnimation1;
         
            //((XYDiagram)arg_chart.Diagram).AxisX.VisualRange.Auto = false;
            //((XYDiagram)arg_chart.Diagram).AxisX.VisualRange.AutoSideMargins = false;
            //((XYDiagram)arg_chart.Diagram).AxisX.VisualRange.SideMarginsValue = 2;
            //((XYDiagram)arg_chart.Diagram).AxisX.Label.Angle = 0;
            ((XYDiagram)arg_chart.Diagram).AxisX.QualitativeScaleOptions.AutoGrid = true;

            ((XYDiagram)arg_chart.Diagram).AxisX.Label.Font = new System.Drawing.Font("Calibri", 8, System.Drawing.FontStyle.Bold);
            ((XYDiagram)arg_chart.Diagram).AxisX.Label.Visible = true;
            ((XYDiagram)arg_chart.Diagram).AxisX.Title.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            ((XYDiagram)arg_chart.Diagram).AxisY.Label.Font = new System.Drawing.Font("Calibri", 10, System.Drawing.FontStyle.Bold);
            
            ((XYDiagram)arg_chart.Diagram).AxisY.Title.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            

            //--------Text AxisX/ AxisY
            ((XYDiagram)arg_chart.Diagram).AxisY.Title.Text = "TEMPERATURE";
            ((XYDiagram)arg_chart.Diagram).AxisY.Title.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            ((XYDiagram)arg_chart.Diagram).AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.Default;

            ((XYDiagram)arg_chart.Diagram).AxisY.VisualRange.MinValue = Convert.ToInt32(arg_dt.Rows[0]["MINVAL"].ToString()) - 5;
            ((XYDiagram)arg_chart.Diagram).AxisY.VisualRange.MaxValue = Convert.ToInt32(arg_dt.Rows[0]["MAXVAL"].ToString()) + 5;
            
            
            ((XYDiagram)arg_chart.Diagram).AxisX.Title.Text = "HMS";
            ((XYDiagram)arg_chart.Diagram).AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.False ;
            ((XYDiagram)arg_chart.Diagram).AxisX.Title.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));


    
           


        }

        private void CreateChartLine(ChartControl arg_chart, DataTable arg_dt1, string arg_name1, string arg_serial_name1, DataTable arg_dt2, string arg_serial_name2)
        {
            try
            {
                if (arg_dt1 == null || arg_dt1.Rows.Count == 0) return;
                if (arg_dt2 == null || arg_dt2.Rows.Count == 0) return;
                int iRow = 0;
                if (arg_dt1.Rows.Count <= arg_dt2.Rows.Count)
                    iRow = arg_dt1.Rows.Count;
                else
                    iRow = arg_dt2.Rows.Count;

                //----------create--------------------
                arg_chart.Series.Clear();
                arg_chart.Titles.Clear();
                arg_chart.AnimationStartMode = ChartAnimationMode.OnDataChanged;

                Series series1 = new Series(arg_serial_name1, ViewType.Spline);
                Series series2 = new Series(arg_serial_name2, ViewType.Spline);

                DevExpress.XtraCharts.SplineSeriesView splineSeriesView1 = new DevExpress.XtraCharts.SplineSeriesView();
                DevExpress.XtraCharts.SplineSeriesView splineSeriesView2 = new DevExpress.XtraCharts.SplineSeriesView();
              
                DevExpress.XtraCharts.XYSeriesUnwindAnimation xySeriesUnwindAnimation1 = new DevExpress.XtraCharts.XYSeriesUnwindAnimation();
               
                DevExpress.XtraCharts.SineEasingFunction sineEasingFunction1 = new DevExpress.XtraCharts.SineEasingFunction();
                DevExpress.XtraCharts.ConstantLine constantLine1 = new DevExpress.XtraCharts.ConstantLine();
                DevExpress.XtraCharts.ConstantLine constantLine2 = new DevExpress.XtraCharts.ConstantLine();


                //--------- Add data Point------------
                if (arg_dt1 != null && arg_dt1.Rows.Count > 0)
                {

                    for (int i = 0; i < iRow; i++)
                    {
                        if (arg_dt1.Rows.Count <= arg_dt2.Rows.Count)
                        {
                            series1.Points.Add(new SeriesPoint(arg_dt1.Rows[i]["T_HMS"].ToString(), arg_dt1.Rows[i]["VALUE"]));
                        }
                        else
                        {
                            series1.Points.Add(new SeriesPoint(arg_dt2.Rows[i]["T_HMS"].ToString(), arg_dt1.Rows[i]["VALUE"]));
                        }

                    }
                }
                series1.ArgumentScaleType = ScaleType.Qualitative;

                if (arg_dt2 != null && arg_dt2.Rows.Count > 0)
                {

                    for (int i = 0; i < iRow; i++)
                    {
                        if (arg_dt1.Rows.Count <= arg_dt2.Rows.Count)
                        {
                            series2.Points.Add(new SeriesPoint(arg_dt1.Rows[i]["T_HMS"].ToString(), arg_dt2.Rows[i]["VALUE"]));
                        }
                        else
                        {
                            series2.Points.Add(new SeriesPoint(arg_dt2.Rows[i]["T_HMS"].ToString(), arg_dt2.Rows[i]["VALUE"]));
                        }

                    }

                }
                series2.ArgumentScaleType = ScaleType.Qualitative;

                arg_chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] { series1, series2 };

                //title
                DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
                chartTitle2.Alignment = System.Drawing.StringAlignment.Near;
                chartTitle2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
                chartTitle2.Text = arg_name1;
                chartTitle2.TextColor = System.Drawing.Color.Blue;
                arg_chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] { chartTitle2 });

                //Constant line
                //constantLine1.ShowInLegend = false;
                constantLine1.AxisValueSerializable = arg_dt1.Rows[0]["MINVAL"].ToString();
                constantLine1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                constantLine1.Name = "Min";
                constantLine2.AxisValueSerializable = arg_dt1.Rows[0]["MAXVAL"].ToString();
                constantLine2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                constantLine2.Name = "Max";
                // constantLine1.ShowBehind = false;
                constantLine1.Title.Visible = false;
                constantLine1.Title.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //constantLine1.Title.Text = "Target";
                constantLine1.LineStyle.Thickness = 3;
                constantLine2.Title.Visible = false;
                constantLine2.Title.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //constantLine1.Title.Text = "Target";
                constantLine2.LineStyle.Thickness = 3;
                // constantLine1.Title.Alignment = DevExpress.XtraCharts.ConstantLineTitleAlignment.Far;
                ((XYDiagram)arg_chart.Diagram).AxisY.ConstantLines.Clear();
                ((XYDiagram)arg_chart.Diagram).AxisY.ConstantLines.AddRange(new DevExpress.XtraCharts.ConstantLine[] { constantLine1, constantLine2 });


                // format Series 


                splineSeriesView1.LineStyle.Thickness = 3;
                splineSeriesView2.LineStyle.Thickness = 3;
                splineSeriesView2.Color = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));

                series1.View = splineSeriesView1;
                series2.View = splineSeriesView2;

                xySeriesUnwindAnimation1.EasingFunction = sineEasingFunction1;
                splineSeriesView1.SeriesAnimation = xySeriesUnwindAnimation1;
                splineSeriesView2.SeriesAnimation = xySeriesUnwindAnimation1;

                ((XYDiagram)arg_chart.Diagram).AxisX.VisualRange.Auto = false;
                ((XYDiagram)arg_chart.Diagram).AxisX.VisualRange.AutoSideMargins = false;
                ((XYDiagram)arg_chart.Diagram).AxisX.VisualRange.SideMarginsValue = 2;
                //((XYDiagram)arg_chart.Diagram).AxisX.Label.Angle = 0;
                ((XYDiagram)arg_chart.Diagram).AxisX.Label.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);               
                ((XYDiagram)arg_chart.Diagram).AxisY.Label.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
                ((XYDiagram)arg_chart.Diagram).AxisX.Label.Visible = true;
                ((XYDiagram)arg_chart.Diagram).AxisX.Title.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ((XYDiagram)arg_chart.Diagram).AxisY.Title.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                ((XYDiagram)arg_chart.Diagram).AxisY.NumericScaleOptions.AutoGrid = false;
                ((XYDiagram)arg_chart.Diagram).AxisY.NumericScaleOptions.GridSpacing = 5;
                //--------Text AxisX/ AxisY
                ((XYDiagram)arg_chart.Diagram).AxisY.Title.Text = "TEMPERATURE";
                ((XYDiagram)arg_chart.Diagram).AxisY.Title.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
                ((XYDiagram)arg_chart.Diagram).AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.Default;

                ((XYDiagram)arg_chart.Diagram).AxisY.VisualRange.Auto = true;
               // ((XYDiagram)arg_chart.Diagram).AxisY.VisualRange.AutoSideMargins = false;
                ((XYDiagram)arg_chart.Diagram).AxisY.VisualRange.SideMarginsValue = 1;               
                //((XYDiagram)arg_chart.Diagram).AxisY.Tickmarks.MinorVisible = false;

                ((XYDiagram)arg_chart.Diagram).AxisY.VisualRange.MinValue = Convert.ToInt32(arg_dt1.Rows[0]["MINVAL"].ToString()) - 5;
                ((XYDiagram)arg_chart.Diagram).AxisY.VisualRange.MaxValue = Convert.ToInt32(arg_dt1.Rows[0]["MAXVAL"].ToString()) + 5;
                //((XYDiagram)arg_chart.Diagram).AxisX.QualitativeScaleOptions.AutoGrid = false;

                //((XYDiagram)arg_chart.Diagram).AxisY.VisualRange.MinValue = 25;
                //((XYDiagram)arg_chart.Diagram).AxisY.VisualRange.MaxValue = 55;


                //((XYDiagram)arg_chart.Diagram).AxisY.VisualRange.SetMinMaxValues(arg_dt1.Rows[0]["MINVAL"], arg_dt1.Rows[0]["MAXVAL"]);

                ((XYDiagram)arg_chart.Diagram).AxisX.Title.Text = "HMS";
                ((XYDiagram)arg_chart.Diagram).AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.Default;
                ((XYDiagram)arg_chart.Diagram).AxisX.Title.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));



            }
            catch (Exception ex)
            {

            }


        }


        private void CreateChartBar(ChartControl arg_chart, DataTable arg_dt, string arg_name, int arg_r, int arg_c)
        {

            if (arg_dt == null || arg_dt.Rows.Count == 0) return;
            arg_chart.Series.Clear();
            arg_chart.Titles.Clear();
            Series series2 = new Series("Development Section", ViewType.Bar);

            //DevExpress.XtraCharts.SplineSeriesView splineSeriesView1 = new DevExpress.XtraCharts.SplineSeriesView();
            //DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            //DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            //DevExpress.XtraCharts.BarWidenAnimation barWidenAnimation1 = new DevExpress.XtraCharts.BarWidenAnimation();
            //DevExpress.XtraCharts.ElasticEasingFunction elasticEasingFunction1 = new DevExpress.XtraCharts.ElasticEasingFunction();


            //DevExpress.XtraCharts.XYSeriesBlowUpAnimation xySeriesBlowUpAnimation1 = new DevExpress.XtraCharts.XYSeriesBlowUpAnimation();
            DevExpress.XtraCharts.XYSeriesUnwindAnimation xySeriesUnwindAnimation1 = new DevExpress.XtraCharts.XYSeriesUnwindAnimation();
            //DevExpress.XtraCharts.XYSeriesUnwrapAnimation xySeriesUnwrapAnimation1 = new DevExpress.XtraCharts.XYSeriesUnwrapAnimation();

            //DevExpress.XtraCharts.PowerEasingFunction powerEasingFunction1 = new DevExpress.XtraCharts.PowerEasingFunction();
            DevExpress.XtraCharts.SineEasingFunction sineEasingFunction1 = new DevExpress.XtraCharts.SineEasingFunction();
            DevExpress.XtraCharts.ConstantLine constantLine1 = new DevExpress.XtraCharts.ConstantLine();


            // Add points to them, with their arguments different.

            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                //series1.Points.Add(new SeriesPoint(dt.Rows[i]["HMS"].ToString(), dt.Rows[i]["QTY"])); //GetRandomNumber(10, 50)
                series2.Points.Add(new SeriesPoint(arg_dt.Rows[i]["DD"].ToString() + "\n" + arg_dt.Rows[i]["DY"].ToString(),
                                arg_dt.Rows[i]["POD"] == null || arg_dt.Rows[i]["POD"].ToString() == "" ? 0 : arg_dt.Rows[i]["POD"]));
            }

            arg_chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] { series2 };
            ((XYDiagram)arg_chart.Diagram).AxisY.Title.Text = "POD";
            ((XYDiagram)arg_chart.Diagram).AxisY.Title.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            ((XYDiagram)arg_chart.Diagram).AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.Default;
            ((XYDiagram)arg_chart.Diagram).AxisX.Title.Text = "Date";
            ((XYDiagram)arg_chart.Diagram).AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.Default;
            ((XYDiagram)arg_chart.Diagram).AxisX.Title.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            ((XYDiagram)arg_chart.Diagram).AxisX.Tickmarks.MinorVisible = false;

            //title
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            chartTitle2.Alignment = System.Drawing.StringAlignment.Near;
            chartTitle2.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            chartTitle2.Text = arg_name;
            chartTitle2.TextColor = System.Drawing.Color.Blue;
            arg_chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] { chartTitle2 });

            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            xySeriesUnwindAnimation1.EasingFunction = sineEasingFunction1; //powerEasingFunction1;

            (series2.Label as SideBySideBarSeriesLabel).Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top;
            //(series2.Label as SideBySideBarSeriesLabel).Font = new Font("Tahoma", 8F);
            //(series2.Label as SideBySideBarSeriesLabel).TextColor = Color.DodgerBlue;


            //Constant line
            //constantLine1.ShowInLegend = false;
            constantLine1.AxisValueSerializable = arg_dt.Rows[0]["TARGET"].ToString();
            constantLine1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            constantLine1.Name = "Target";
            constantLine1.ShowBehind = false;
            constantLine1.Title.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            constantLine1.Title.Text = "Target";
            constantLine1.LineStyle.Thickness = 2;
            constantLine1.Title.Alignment = DevExpress.XtraCharts.ConstantLineTitleAlignment.Far;
            ((XYDiagram)arg_chart.Diagram).AxisY.ConstantLines.Clear();
            ((XYDiagram)arg_chart.Diagram).AxisY.ConstantLines.AddRange(new DevExpress.XtraCharts.ConstantLine[] { constantLine1 });

            
            ((XYDiagram)arg_chart.Diagram).AxisX.VisualRange.Auto = false;
            ((XYDiagram)arg_chart.Diagram).AxisX.VisualRange.AutoSideMargins = false;
            ((XYDiagram)arg_chart.Diagram).AxisX.VisualRange.SideMarginsValue = 2;
            ((XYDiagram)arg_chart.Diagram).AxisX.Label.Angle = 0;
            ((XYDiagram)arg_chart.Diagram).AxisX.Label.Font = new System.Drawing.Font("Tahoma", 10, System.Drawing.FontStyle.Bold);
            ((XYDiagram)arg_chart.Diagram).AxisX.NumericScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Continuous;
            //((XYDiagram)_chartControl1.Diagram).AxisY.NumericScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Automatic;
            ((XYDiagram)arg_chart.Diagram).AxisY.Label.Font = new System.Drawing.Font("Tahoma", 10, System.Drawing.FontStyle.Bold);

            ((XYDiagram)arg_chart.Diagram).AxisX.Title.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ((XYDiagram)arg_chart.Diagram).AxisY.Title.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            

            tpn_show.Controls.Add(arg_chart, arg_r, arg_c);
        }


        #endregion Func


        #region DB
        private DataTable LOAD_DATA()
        {           
            try
            {
                COM.OraDB MyOraDB = new COM.OraDB();
                System.Data.DataSet ds_ret;

                string process_name = "MES.PKG_OS_RUB_TEMP_TRACKING.SP_RUB_TEMP_TRACKING";
                //ARGMODE
                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = process_name;
                MyOraDB.Parameter_Name[0] = "CV_1";
                MyOraDB.Parameter_Type[0] = (char)OracleType.Cursor;
                MyOraDB.Parameter_Values[0] = "";
                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();
                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }
        }

        private DataTable LOAD_DATA_HISTORY(string ARG_MLINE_CD, string ARG_MC_ID, string ARG_ROLL_OP_CD)
        {
            try
            {
                COM.OraDB MyOraDB = new COM.OraDB();
                System.Data.DataSet ds_ret;

                // string process_name = "MES.PKG_OS_RUB_TEMP_TRACKING.SP_RUB_TEMP_HISTORY";
                string process_name = "MES.PKG_SMT_B1_DIGITAL.SP_RUB_TEMP_HISTORY";
                //ARGMODE
                MyOraDB.ReDim_Parameter(4);
                MyOraDB.Process_Name = process_name;
                MyOraDB.Parameter_Name[0] = "ARG_MLINE_CD";
                MyOraDB.Parameter_Name[1] = "ARG_MC_ID";
                MyOraDB.Parameter_Name[2] = "ARG_ROLL_OP_CD";
                MyOraDB.Parameter_Name[3] = "CV_1";
                MyOraDB.Parameter_Type[0] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (char)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (char)OracleType.Cursor;
                MyOraDB.Parameter_Values[0] = ARG_MLINE_CD;
                MyOraDB.Parameter_Values[1] = ARG_MC_ID;
                MyOraDB.Parameter_Values[2] = ARG_ROLL_OP_CD;
                MyOraDB.Parameter_Values[3] = "";
                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();
                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }
        }


        

        #endregion DB

        #region event
        private void timer1_Tick(object sender, EventArgs e)
        {
            icount++;
            if (icount == 20)
            {
                load_data();
                load_data_history();
                icount = 0;
            }
        }


        private void load_data()
        {
            

            DataTable dt = LOAD_DATA();
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                {
                    if (dt.Rows[iRow]["MLINE_CD"].ToString() == "BB101" && dt.Rows[iRow]["ROLL_OP_CD"].ToString() == "BANB" && dt.Rows[iRow]["MC_ID"].ToString() == "001")
                    {
                        iBanburyMC1 = Convert.ToDouble(dt.Rows[iRow]["VALUE"].ToString());
                        dBanburyMC1Min = Convert.ToInt32(dt.Rows[iRow]["MINVAL"].ToString());
                        dBanburyMC1Max = Convert.ToInt32(dt.Rows[iRow]["MaxVAL"].ToString());
                    }

                    if (dt.Rows[iRow]["MLINE_CD"].ToString() == "BB102" && dt.Rows[iRow]["ROLL_OP_CD"].ToString() == "BANB" && dt.Rows[iRow]["MC_ID"].ToString() == "001")
                    {
                        iBanburyMC2 = Convert.ToDouble(dt.Rows[iRow]["VALUE"].ToString());
                        dBanburyMC2Min = Convert.ToInt32(dt.Rows[iRow]["MINVAL"].ToString());
                        dBanburyMC2Max = Convert.ToInt32(dt.Rows[iRow]["MaxVAL"].ToString());
                    }

                    if (dt.Rows[iRow]["MLINE_CD"].ToString() == "BB101" && dt.Rows[iRow]["ROLL_OP_CD"].ToString() == "BANB" && dt.Rows[iRow]["MC_ID"].ToString() == "002")
                    {
                        iBanburyMat1 = Convert.ToDouble(dt.Rows[iRow]["VALUE"].ToString());
                        dBanburyMat1Min = Convert.ToInt32(dt.Rows[iRow]["MINVAL"].ToString());
                        dBanburyMat1Max = Convert.ToInt32(dt.Rows[iRow]["MaxVAL"].ToString());
                    }
                    if (dt.Rows[iRow]["MLINE_CD"].ToString() == "BB102" && dt.Rows[iRow]["ROLL_OP_CD"].ToString() == "BANB" && dt.Rows[iRow]["MC_ID"].ToString() == "002")
                    {
                        iBanburyMat2 = Convert.ToDouble(dt.Rows[iRow]["VALUE"].ToString());
                        dBanburyMat2Min = Convert.ToInt32(dt.Rows[iRow]["MINVAL"].ToString());
                        dBanburyMat2Max = Convert.ToInt32(dt.Rows[iRow]["MaxVAL"].ToString());
                    }


                    if (dt.Rows[iRow]["MLINE_CD"].ToString() == "BB101" && dt.Rows[iRow]["ROLL_OP_CD"].ToString() == "ROLL" && dt.Rows[iRow]["MC_ID"].ToString() == "003")
                    {
                        iRoll1MC1 = Convert.ToDouble(dt.Rows[iRow]["VALUE"].ToString());
                        dRoll1MC1Min = Convert.ToInt32(dt.Rows[iRow]["MINVAL"].ToString());
                        dRoll1MC1Max = Convert.ToInt32(dt.Rows[iRow]["MaxVAL"].ToString());
                    }
                    if (dt.Rows[iRow]["MLINE_CD"].ToString() == "BB102" && dt.Rows[iRow]["ROLL_OP_CD"].ToString() == "ROLL" && dt.Rows[iRow]["MC_ID"].ToString() == "003")
                    {
                        iRoll1MC2 = Convert.ToDouble(dt.Rows[iRow]["VALUE"].ToString());
                        dRoll1MC2Min = Convert.ToInt32(dt.Rows[iRow]["MINVAL"].ToString());
                        dRoll1MC2Max = Convert.ToInt32(dt.Rows[iRow]["MaxVAL"].ToString());
                    }

                    if (dt.Rows[iRow]["MLINE_CD"].ToString() == "BB101" && dt.Rows[iRow]["ROLL_OP_CD"].ToString() == "ROLL" && dt.Rows[iRow]["MC_ID"].ToString() == "007")
                    {
                        iRoll2MC1 = Convert.ToDouble(dt.Rows[iRow]["VALUE"].ToString());
                        dRoll2MC1Min = Convert.ToInt32(dt.Rows[iRow]["MINVAL"].ToString());
                        dRoll2MC1Max = Convert.ToInt32(dt.Rows[iRow]["MaxVAL"].ToString());
                    }
                    if (dt.Rows[iRow]["MLINE_CD"].ToString() == "BB102" && dt.Rows[iRow]["ROLL_OP_CD"].ToString() == "ROLL" && dt.Rows[iRow]["MC_ID"].ToString() == "007")
                    {
                        iRoll2MC2 = Convert.ToDouble(dt.Rows[iRow]["VALUE"].ToString());
                        dRoll2MC2Min = Convert.ToInt32(dt.Rows[iRow]["MINVAL"].ToString());
                        dRoll2MC2Max = Convert.ToInt32(dt.Rows[iRow]["MaxVAL"].ToString());
                    }



                    if (dt.Rows[iRow]["MLINE_CD"].ToString() == "BB101" && dt.Rows[iRow]["ROLL_OP_CD"].ToString() == "CALD" && dt.Rows[iRow]["MC_ID"].ToString() == "008")
                    {
                        iCalendarMC1 = Convert.ToDouble(dt.Rows[iRow]["VALUE"].ToString());
                        dCalendarMC1Min = Convert.ToInt32(dt.Rows[iRow]["MINVAL"].ToString());
                        dCalendarMC1Max = Convert.ToInt32(dt.Rows[iRow]["MaxVAL"].ToString());
                    }

                    if (dt.Rows[iRow]["MLINE_CD"].ToString() == "BB102" && dt.Rows[iRow]["ROLL_OP_CD"].ToString() == "CALD" && dt.Rows[iRow]["MC_ID"].ToString() == "008")
                    {
                        iCalendarMC2 = Convert.ToDouble(dt.Rows[iRow]["VALUE"].ToString());
                        dCalendarMC2Min = Convert.ToInt32(dt.Rows[iRow]["MINVAL"].ToString());
                        dCalendarMC2Max = Convert.ToInt32(dt.Rows[iRow]["MaxVAL"].ToString());
                    }

                    if (dt.Rows[iRow]["MLINE_CD"].ToString() == "BB101" && dt.Rows[iRow]["ROLL_OP_CD"].ToString() == "CALD" && dt.Rows[iRow]["MC_ID"].ToString() == "009")
                    {
                        iCalendarMat1 = Convert.ToDouble(dt.Rows[iRow]["VALUE"].ToString());
                        dCalendarMat1Min = Convert.ToInt32(dt.Rows[iRow]["MINVAL"].ToString());
                        dCalendarMat1Max = Convert.ToInt32(dt.Rows[iRow]["MaxVAL"].ToString());
                    }
                    if (dt.Rows[iRow]["MLINE_CD"].ToString() == "BB102" && dt.Rows[iRow]["ROLL_OP_CD"].ToString() == "CALD" && dt.Rows[iRow]["MC_ID"].ToString() == "009")
                    {
                        iCalendarMat2 = Convert.ToDouble(dt.Rows[iRow]["VALUE"].ToString());
                        dCalendarMat2Min = Convert.ToInt32(dt.Rows[iRow]["MINVAL"].ToString());
                        dCalendarMat2Max = Convert.ToInt32(dt.Rows[iRow]["MaxVAL"].ToString());
                    }



                }

            }



            BindingGauges(lnBanburyMC1, iBanburyMC1, dBanburyMC1Min - 10, dBanburyMC1Max + 10, dBanburyMC1Min, dBanburyMC1Max);

            lblBanburyLine1MC.Text = "Temp: " + iBanburyMC1.ToString() + " °C";
            lblBanburyLine1MCMin.Text = "Min: " + dBanburyMC1Min.ToString() + " °C";
            lblBanburyLine1MCMax.Text = "Max: " + dBanburyMC1Max.ToString() + " °C";

            BindingGauges(lnBanburyMC2, iBanburyMC2, dBanburyMC2Min - 10, dBanburyMC2Max + 10, dBanburyMC2Min, dBanburyMC2Max);
            lblBanburyLine2MC.Text = "Temp: " + iBanburyMC2.ToString() + " °C";
            lblBanburyLine2MCMin.Text = "Min: " + dBanburyMC2Min.ToString() + " °C";
            lblBanburyLine2MCMax.Text = "Max: " + dBanburyMC2Max.ToString() + " °C";

            BindingGauges(cirBanburyMat1, iBanburyMat1, dBanburyMat1Min - 10, dBanburyMat1Max + 10, dBanburyMat1Min, dBanburyMat1Max);
            lblBanburyLine1Mat.Text = "Temp: " + iBanburyMat1.ToString() + " °C";
            lblBanburyLine1MatMin.Text = "Min: " + dBanburyMat1Min.ToString() + " °C";
            lblBanburyLine1MatMax.Text = "Max: " + dBanburyMat1Max.ToString() + " °C";

            BindingGauges(cirBanburyMat2, iBanburyMat2, dBanburyMat2Min - 10, dBanburyMat2Max + 10, dBanburyMat2Min, dBanburyMat2Max);
            lblBanburyLine2Mat.Text = "Temp: " + iBanburyMat2.ToString() + " °C";
            lblBanburyLine2MatMin.Text = "Min: " + dBanburyMat2Min.ToString() + " °C";
            lblBanburyLine2MatMax.Text = "Max: " + dBanburyMat2Max.ToString() + " °C";


            BindingGauges(lnRollMC11, iRoll1MC1, dRoll1MC1Min - 10, dRoll1MC1Max + 10, dRoll1MC1Min, dRoll1MC1Max);

            lblRoll1Line1MC.Text = "Temp: " + iRoll1MC1.ToString() + " °C";
            lblRoll1Line1MCMin.Text = "Min: " + dRoll1MC1Min.ToString() + " °C";
            lblRoll1Line1MCMax.Text = "Max: " + dRoll1MC1Max.ToString() + " °C";

            BindingGauges(lnRollMC12, iRoll1MC2, dRoll1MC2Min - 10, dRoll1MC2Max + 10, dRoll1MC2Min, dRoll1MC2Max);
            lblRoll1Line2MC.Text = "Temp: " + iRoll1MC2.ToString() + " °C";
            lblRoll1Line2MCMin.Text = "Min: " + dRoll1MC2Min.ToString() + " °C";
            lblRoll1Line2MCMax.Text = "Max: " + dRoll1MC2Max.ToString() + " °C";

            BindingGauges(lnRollMC21, iRoll2MC1, dRoll2MC1Min - 10, dRoll2MC1Max + 10, dRoll2MC1Min, dRoll2MC1Max);

            lblRoll2Line1MC.Text = "Temp: " + iRoll2MC1.ToString() + " °C";
            lblRoll2Line1MCMin.Text = "Min: " + dRoll2MC1Min.ToString() + " °C";
            lblRoll2Line1MCMax.Text = "Max: " + dRoll2MC1Max.ToString() + " °C";

            BindingGauges(lnRollMC22, iRoll2MC2, dRoll2MC2Min - 10, dRoll2MC2Max + 10, dRoll2MC2Min, dRoll2MC2Max);

            lblRoll2Line2MC.Text = "Temp: " + iRoll2MC2.ToString() + " °C";
            lblRoll2Line2MCMin.Text = "Min: " + dRoll2MC2Min.ToString() + " °C";
            lblRoll2Line2MCMax.Text = "Max: " + dRoll2MC2Max.ToString() + " °C";


            BindingGauges(lnCalendarMC1, iCalendarMC1, dCalendarMC1Min - 10, dCalendarMC1Max + 10, dCalendarMC1Min, dCalendarMC1Max);

            lblCalendarLine1MC.Text = "Temp: " + iCalendarMC1.ToString() + " °C";
            lblCalendarLine1MCMin.Text = "Min: " + dCalendarMC1Min.ToString() + " °C";
            lblCalendarLine1MCMax.Text = "Max: " + dCalendarMC1Max.ToString() + " °C";

            BindingGauges(lnCalendarMC2, iCalendarMC2, dCalendarMC2Min - 10, dCalendarMC2Max + 10, dCalendarMC2Min, dCalendarMC2Max);

            lblCalendarLine2MC.Text = "Temp: " + iCalendarMC2.ToString() + " °C";
            lblCalendarLine2MCMin.Text = "Min: " + dCalendarMC2Min.ToString() + " °C";
            lblCalendarLine2MCMax.Text = "Max: " + dCalendarMC2Max.ToString() + " °C";

            BindingGauges(cirCalendarMat1, iCalendarMat1, dCalendarMat1Min - 10, dCalendarMat1Max + 10, dCalendarMat1Min, dCalendarMat1Max);


            lblCalendarLine1Mat.Text = "Temp: " + iCalendarMat1.ToString() + " °C";
            lblCalendarLine1MatMin.Text = "Min: " + dCalendarMat1Min.ToString() + " °C";
            lblCalendarLine1MatMax.Text = "Max: " + dCalendarMat1Max.ToString() + " °C";


            BindingGauges(cirCalendarMat2, iCalendarMat2, dCalendarMat2Min - 10, dCalendarMat2Max + 10, dCalendarMat2Min, dCalendarMat2Max);
            lblCalendarLine2Mat.Text = "Temp: " + iCalendarMat2.ToString() + " °C";
            lblCalendarLine2MatMin.Text = "Min: " + dCalendarMat2Min.ToString() + " °C";
            lblCalendarLine2MatMax.Text = "Max: " + dCalendarMat2Max.ToString() + " °C";
          
           
        }


        private void load_data_history()
        {
            DataTable dt1, dt2;
            dt1 = LOAD_DATA_HISTORY("BB102", "001", "BANB");
            if (dt1 != null && dt1.Rows.Count > 0)
            {
                CreateChartLine(chartBanbury, dt1, "Banbury"," M/C");
            }
            dt1 = null;
            dt1 = LOAD_DATA_HISTORY("BB102", "003", "ROLL");
            if (dt1 != null && dt1.Rows.Count > 0)
            {
                CreateChartLine(chartRoll1, dt1, "Roll No. 1", "M/C");
               
            }
            dt1 = null;
            dt2 = null;
            dt1 = LOAD_DATA_HISTORY("BB101", "007", "ROLL");
            dt2 = LOAD_DATA_HISTORY("BB102", "007", "ROLL");          
         
            CreateChartLine(chartRoll2, dt1, "Roll No. 2", "M/C 1", dt2, "M/C 2");

            dt1 = null;
            dt2 = null;
            dt1 = LOAD_DATA_HISTORY("BB101", "008", "CALD");
            dt2 = LOAD_DATA_HISTORY("BB102", "008", "CALD");
            
           CreateChartLine(chartCalendar, dt1, "Calendar", "M/C 1", dt2, "M/C 2");
           

        }
        private void BindingGauges(DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge circularGauge, double num, double iMin, double iMax, double iRangeMin, double iRangeMax)
        {
            // DataTable dt = SEL_POD("014", "001");
            if (circularGauge.Scales.Count <= 0)
            {
                return;
            }
            double _iMin=0, _iMax = 100;
            if (num > 0)
            {
                _iMin = iMin;
                _iMax = iMax;
            }
            circularGauge.Scales[0].EnableAnimation = false;
            //arcScaleGauges.EasingFunction = new BackEase();
            circularGauge.Scales[0].MinValue = (float)_iMin;
            circularGauge.Scales[0].MaxValue = (float) _iMax;
         
            circularGauge.Scales[0].Value = 0;

            //circularGauge.Labels[0].Text = "0";
            if (circularGauge.Scales[0].Ranges.Count >= 3 && num > 0)
            {
                circularGauge.Scales[0].Ranges[0].StartValue = (float)iMin;
                circularGauge.Scales[0].Ranges[0].EndValue = (float)iRangeMin;
                circularGauge.Scales[0].Ranges[1].StartValue = (float)iRangeMin;
                circularGauge.Scales[0].Ranges[1].EndValue = (float)iRangeMax;
                circularGauge.Scales[0].Ranges[2].StartValue = (float)iRangeMax;
                circularGauge.Scales[0].Ranges[2].EndValue = (float)iMax;

            }
            //labelGauges.Text = "0";
            //if (dt != null && dt.Rows.Count > 0)
            //{
            try
            {

              

                circularGauge.Scales[0].EnableAnimation = true;
                circularGauge.Scales[0].EasingMode = DevExpress.XtraGauges.Core.Model.EasingMode.EaseInOut;
                //arcScaleGauges.EasingFunction = new BackEase();


               
                 circularGauge.Scales[0].Value = (float)num;
                 
               
                //labelGauges.Text = num.ToString();
            }
            catch (Exception ex)
            { }
            // }
        }

        private void BindingGauges(DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge, double num, double iMin, double iMax, double iRangeMin, double iRangeMax)
        {
            // DataTable dt = SEL_POD("014", "001");
            if (circularGauge.Scales.Count <= 0)
            {
                return;
            }
            double _iMin = 0, _iMax = 100;
            if (num > 0)
            {
                _iMin = iMin;
                _iMax = iMax;
            }
            circularGauge.Scales[0].EnableAnimation = false;
            //arcScaleGauges.EasingFunction = new BackEase();
            circularGauge.Scales[0].MinValue = (float)_iMin;
            circularGauge.Scales[0].MaxValue = (float)_iMax;
            //arcScaleGauges.Ranges[0].EndValue = arcScaleGauges.Ranges[1].StartValue = Convert.ToSingle(10);
            //arcScaleGauges.Ranges[1].EndValue = arcScaleGauges.Ranges[2].StartValue = Convert.ToSingle(15);
            //arcScaleGauges.Ranges[2].EndValue = Convert.ToSingle(20);
            circularGauge.Scales[0].Value = 0;

            if (circularGauge.Scales[0].Ranges.Count >= 3 && num > 0)
            {
                circularGauge.Scales[0].Ranges[0].StartValue = (float)iMin;
                circularGauge.Scales[0].Ranges[0].EndValue = (float)iRangeMin;
                circularGauge.Scales[0].Ranges[1].StartValue = (float)iRangeMin;
                circularGauge.Scales[0].Ranges[1].EndValue = (float)iRangeMax;
                circularGauge.Scales[0].Ranges[2].StartValue = (float)iRangeMax;
                circularGauge.Scales[0].Ranges[2].EndValue = (float)iMax;

            }
            //labelGauges.Text = "0";
            //if (dt != null && dt.Rows.Count > 0)
            //{
            try
            {

                //circularGauge.Scales[0].MinValue = (float)iMin;
                //circularGauge.Scales[0].MaxValue = (float)iMax;
                //arcScaleGauges.Ranges[0].EndValue = arcScaleGauges.Ranges[1].StartValue = Convert.ToSingle(Convert.ToSingle(dt.Rows[0][0]) - 2);
                //arcScaleGauges.Ranges[1].EndValue = arcScaleGauges.Ranges[2].StartValue = Convert.ToSingle(Convert.ToSingle(dt.Rows[0][0]) + 2);
                //arcScaleGauges.Ranges[2].EndValue = Convert.ToSingle(Convert.ToSingle(dt.Rows[0][0]) + 5);

                circularGauge.Scales[0].EnableAnimation = true;
                circularGauge.Scales[0].EasingMode = DevExpress.XtraGauges.Core.Model.EasingMode.EaseInOut;
                //arcScaleGauges.EasingFunction = new BackEase();


                    circularGauge.Scales[0].Value = (float)num;
                  
                //labelGauges.Text = num.ToString();
            }
            catch (Exception ex)
            { }
            // }
        }

        private void FRM_RUB_TEMP_TRACKING_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.Visible)
                {
                    icount = 29;
                    _load = true;
                    tmrLoad.Start();
                    //panel2.BringToFront();
                    
                    
                }
                else
                {
                    tmrTime.Stop();
                    tmrLoad.Stop();
                }
            }
            catch (Exception ex)
            {}
                
        }



        private void FRM_RUB_TEMP_TRACKING_Load(object sender, EventArgs e)
        {
            try
            {
                GoFullscreen(true);

                pnEVA.GradientEndColor = Color.Gray; //Color.FromArgb(255, 128, 128);
                pnRubber.GradientEndColor = Color.White;

                

               // ClassLib.ComCtl.Form_Maximized(this, indexScreen); //2 man hinh tro len

                //load_data();
                //load_data_history();
                pnButton.Visible = false;
                lblTitle.Text = "Rubber Temperature Tracking";
               // CreateChartLine(Chart1, ds.Tables[1], "Cutting", 0,0);
                
                //createChart1(chart_1, "Cutting");
                //createChart2(chart_2, "Stockfit");
                //createChart3(chart_3, "Stitching");
                //createChart4(chart_4, "Assembly");

                tmrBlindLable.Interval = 500;
                tmrBlindLable.Start();


              //  load_data();
            }
            catch (Exception)
            {}
            
        }

        #endregion event

        private void tmrBlindLable_Tick(object sender, EventArgs e)
        {
            BlindLabel(lblBanburyLine1MC, iBanburyMC1, dBanburyMC1Min, dBanburyMC1Max);
            BlindLabel(lblBanburyLine2MC, iBanburyMC2, dBanburyMC2Min, dBanburyMC2Max);
            BlindLabel(lblBanburyLine1Mat, iBanburyMat1, dBanburyMat1Min, dBanburyMat1Max);
            BlindLabel(lblBanburyLine2Mat, iBanburyMat2, dBanburyMat2Min, dBanburyMat2Max);
        }

        private void btnEva_Click(object sender, EventArgs e)
        {
           
        }

        private void lblEVA_Click(object sender, EventArgs e)
        {
            Form_Home._frmMachinery_EvaTemp.Show();
            this.Hide();
        }

        private void tmrLoad_Tick(object sender, EventArgs e)
        {
            icount++;
            if (icount == 30)
            {
                load_data();
                load_data_history();
                icount = 0;
            }
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // FRM_RUB_TEMP_TRACKING
        //    // 
        //    this.ClientSize = new System.Drawing.Size(428, 374);
        //    this.Name = "FRM_RUB_TEMP_TRACKING";
        //    this.ResumeLayout(false);

        //}





    }
}
