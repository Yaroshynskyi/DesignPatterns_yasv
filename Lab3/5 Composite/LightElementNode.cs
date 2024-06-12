using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Composite
{
    public class LightElementNode : LightNode
    {
        private string _tagName;
        private bool _isBlock;
        private bool _isSelfClosing;
        private List<string> _cssClasses;
        private List<LightNode> _children;
        private LifecycleHooks _lifecycleHooks;

        public LightElementNode(string tagName, bool isBlock, bool isSelfClosing, LifecycleHooks lifecycleHooks = null)
        {
            this._tagName = tagName;
            this._isBlock = isBlock;
            this._isSelfClosing = isSelfClosing;
            this._cssClasses = new List<string>();
            this._children = new List<LightNode>();
            this._lifecycleHooks = lifecycleHooks ?? new ConcreteLifecycleHooks();
            this._lifecycleHooks.OnCreated(this);
        }

        public string TagName => _tagName;

        public void AddClass(string cssClass)
        {
            _cssClasses.Add(cssClass);
            _lifecycleHooks.OnClassListApplied(this);
        }

        public void AddChild(LightNode child)
        {
            _children.Add(child);
            _lifecycleHooks.OnInserted(this, child);
        }

        public void RemoveChild(LightNode child)
        {
            _children.Remove(child);
            _lifecycleHooks.OnRemoved(this, child);
        }

        public override string OuterHtml
        {
            get
            {
                string classes = _cssClasses.Any() ? $" class=\"{string.Join(" ", _cssClasses)}\"" : "";
                string startTag = $"<{_tagName}{classes}>";
                string endTag = _isSelfClosing ? "" : $"</{_tagName}>";
                return startTag + InnerHtml + endTag;
            }
        }

        public override string InnerHtml
        {
            get
            {
                return string.Join(_isBlock ? "\n" : "", _children.Select(child => child.OuterHtml));
            }
        }

        public List<LightNode> GetChildren()
        {
            return _children;
        }
    }

}



