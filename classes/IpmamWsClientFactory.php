<?php
class IpmamWsClientFactory
{
    /**
     *
     */
    function __construct()
    {
        // Create the clientService object if it doesn't exists
        if (!isset($this->cs)) {
            $this->cs = new clientService();
            $this->services = array();
            $this->vars = array();
        }
    }

    /**
     *
     */
    function setVar($var, $val)
    {
        $this->vars[$var] = $val;
    }

    /**
     *
     */
    function getVar($var)
    {
        if (isset($this->vars[$var])) {
            return $this->vars[$var];
        } else {
            return null;
        }
    }

    /**
     *
     */
    function unsetVar($var)
    {
        if (isset($this->vars[$var])) {
            unset($this->vars[$var]);
        }
    }

    /**
     *
     */
    function client($name, $serviceName = NULL)
    {
        if (isset($serviceName)) {
            $this->services[$name] = $this->cs->createClient($serviceName);
        }

        if (!isset($this->services[$name])) {
            $this->services[$name] = NULL;
        }

        return $this->services[$name];
    }

    /**
     *
     */
    function factory($name, $params)
    {
        if (!isset($this->params[$name])) {
            $this->params[$name] = new $name($params);
            //$this->params[$name] = new $name("'".implode("', '", $params)."'");
        } else {
            $this->_resetObject($this->params[$name]);
        }
        $this->_loadObject($this->params[$name], $params);

        //pr($this->params[$name]);
        return $this->params[$name];
    }

    /**
     *
     */
    function _resetObject(&$object)
    {
        foreach ($object as $key => $value) {
            $object->$key = NULL;
        }
    }

    /**
     *
     */
    function _loadObject(&$object, $values)
    {
        $i = 0;
        foreach ($object as $key => $value) {
            if (count($values) > 0) {
                $object->$key = $values[$i++];
            }
        }
    }
}
?>