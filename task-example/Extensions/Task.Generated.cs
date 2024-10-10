//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace Task
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Bonsai.Sgen", "0.4.0.0 (YamlDotNet v13.0.0.0)")]
    [Bonsai.CombinatorAttribute()]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Source)]
    public partial class Block
    {
    
        private System.Collections.Generic.List<Trials> _trials = new System.Collections.Generic.List<Trials>();
    
        public Block()
        {
        }
    
        protected Block(Block other)
        {
            _trials = other._trials;
        }
    
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="trials")]
        public System.Collections.Generic.List<Trials> Trials
        {
            get
            {
                return _trials;
            }
            set
            {
                _trials = value;
            }
        }
    
        public System.IObservable<Block> Process()
        {
            return System.Reactive.Linq.Observable.Defer(() => System.Reactive.Linq.Observable.Return(new Block(this)));
        }
    
        public System.IObservable<Block> Process<TSource>(System.IObservable<TSource> source)
        {
            return System.Reactive.Linq.Observable.Select(source, _ => new Block(this));
        }
    
        protected virtual bool PrintMembers(System.Text.StringBuilder stringBuilder)
        {
            stringBuilder.Append("trials = " + _trials);
            return true;
        }
    
        public override string ToString()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            stringBuilder.Append(GetType().Name);
            stringBuilder.Append(" { ");
            if (PrintMembers(stringBuilder))
            {
                stringBuilder.Append(" ");
            }
            stringBuilder.Append("}");
            return stringBuilder.ToString();
        }
    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("Bonsai.Sgen", "0.4.0.0 (YamlDotNet v13.0.0.0)")]
    [Bonsai.CombinatorAttribute()]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Source)]
    public partial class Trials
    {
    
        private double _posX;
    
        private double _posY;
    
        private double _iti;
    
        private double _duration;
    
        public Trials()
        {
        }
    
        protected Trials(Trials other)
        {
            _posX = other._posX;
            _posY = other._posY;
            _iti = other._iti;
            _duration = other._duration;
        }
    
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="pos_x")]
        public double PosX
        {
            get
            {
                return _posX;
            }
            set
            {
                _posX = value;
            }
        }
    
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="pos_y")]
        public double PosY
        {
            get
            {
                return _posY;
            }
            set
            {
                _posY = value;
            }
        }
    
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="iti")]
        public double Iti
        {
            get
            {
                return _iti;
            }
            set
            {
                _iti = value;
            }
        }
    
        [YamlDotNet.Serialization.YamlMemberAttribute(Alias="duration")]
        public double Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                _duration = value;
            }
        }
    
        public System.IObservable<Trials> Process()
        {
            return System.Reactive.Linq.Observable.Defer(() => System.Reactive.Linq.Observable.Return(new Trials(this)));
        }
    
        public System.IObservable<Trials> Process<TSource>(System.IObservable<TSource> source)
        {
            return System.Reactive.Linq.Observable.Select(source, _ => new Trials(this));
        }
    
        protected virtual bool PrintMembers(System.Text.StringBuilder stringBuilder)
        {
            stringBuilder.Append("pos_x = " + _posX + ", ");
            stringBuilder.Append("pos_y = " + _posY + ", ");
            stringBuilder.Append("iti = " + _iti + ", ");
            stringBuilder.Append("duration = " + _duration);
            return true;
        }
    
        public override string ToString()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            stringBuilder.Append(GetType().Name);
            stringBuilder.Append(" { ");
            if (PrintMembers(stringBuilder))
            {
                stringBuilder.Append(" ");
            }
            stringBuilder.Append("}");
            return stringBuilder.ToString();
        }
    }


    /// <summary>
    /// Serializes a sequence of data model objects into YAML strings.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Bonsai.Sgen", "0.4.0.0 (YamlDotNet v13.0.0.0)")]
    [System.ComponentModel.DescriptionAttribute("Serializes a sequence of data model objects into YAML strings.")]
    [Bonsai.CombinatorAttribute()]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Transform)]
    public partial class SerializeToYaml
    {
    
        private System.IObservable<string> Process<T>(System.IObservable<T> source)
        {
            return System.Reactive.Linq.Observable.Defer(() =>
            {
                var serializer = new YamlDotNet.Serialization.SerializerBuilder()
                    .Build();
                return System.Reactive.Linq.Observable.Select(source, value => serializer.Serialize(value)); 
            });
        }

        public System.IObservable<string> Process(System.IObservable<Block> source)
        {
            return Process<Block>(source);
        }

        public System.IObservable<string> Process(System.IObservable<Trials> source)
        {
            return Process<Trials>(source);
        }
    }


    /// <summary>
    /// Deserializes a sequence of YAML strings into data model objects.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Bonsai.Sgen", "0.4.0.0 (YamlDotNet v13.0.0.0)")]
    [System.ComponentModel.DescriptionAttribute("Deserializes a sequence of YAML strings into data model objects.")]
    [System.ComponentModel.DefaultPropertyAttribute("Type")]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Transform)]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Bonsai.Expressions.TypeMapping<Block>))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Bonsai.Expressions.TypeMapping<Trials>))]
    public partial class DeserializeFromYaml : Bonsai.Expressions.SingleArgumentExpressionBuilder
    {
    
        public DeserializeFromYaml()
        {
            Type = new Bonsai.Expressions.TypeMapping<Block>();
        }

        public Bonsai.Expressions.TypeMapping Type { get; set; }

        public override System.Linq.Expressions.Expression Build(System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments)
        {
            var typeMapping = (Bonsai.Expressions.TypeMapping)Type;
            var returnType = typeMapping.GetType().GetGenericArguments()[0];
            return System.Linq.Expressions.Expression.Call(
                typeof(DeserializeFromYaml),
                "Process",
                new System.Type[] { returnType },
                System.Linq.Enumerable.Single(arguments));
        }

        private static System.IObservable<T> Process<T>(System.IObservable<string> source)
        {
            return System.Reactive.Linq.Observable.Defer(() =>
            {
                var serializer = new YamlDotNet.Serialization.DeserializerBuilder()
                    .Build();
                return System.Reactive.Linq.Observable.Select(source, value =>
                {
                    var reader = new System.IO.StringReader(value);
                    var parser = new YamlDotNet.Core.MergingParser(new YamlDotNet.Core.Parser(reader));
                    return serializer.Deserialize<T>(parser);
                });
            });
        }
    }
}